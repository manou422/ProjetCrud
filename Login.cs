using MySql.Data.MySqlClient;
using Projet_BTS2;

namespace Test_projet
{
    public partial class Login : Form
    {

        DBConnection LaConnexion = new DBConnection();
        public Login()
        {
            InitializeComponent();
            LaConnexion.Server = "localhost";
            LaConnexion.DatabaseName = "Sucrerie";
            LaConnexion.UserName = "root";
            LaConnexion.Password = Crypto.Decrypt("xJdhnrU7njlOqo2QusEkwQ==");
        }

        private void BTOk_Click(object sender, EventArgs e)
        {
            string query = "SELECT prenom,mail,mdp,admin FROM utilisateurs WHERE mail = @mail AND mdp = @mdp";


            if (LaConnexion.IsConnect())
            {

                using (MySqlCommand cmd = new MySqlCommand(query, LaConnexion.Connection))
                {
                    cmd.Parameters.AddWithValue("@mail", TBMail.Text);
                    cmd.Parameters.AddWithValue("@mdp", Crypto.HasherMotDePasse(TBMdp.Text));

                    try
                    {

                        MySqlDataReader reader = cmd.ExecuteReader();

                        int rowCount = 0;
                        while (reader.Read())
                        {
                            rowCount++;
                        }



                        if (rowCount == 1)
                        {
                            String prenom = (string)reader["prenom"];
                            int admin = Convert.ToInt32(reader["admin"]);
                            reader.Close();
                            if (admin == 1)
                            {
                                Form1 formPrincipal = new Form1(LaConnexion, prenom);
                                formPrincipal.Show();
                            }
                            else
                            {
                                FormOperateur formPrincipal = new FormOperateur(LaConnexion, prenom);
                                formPrincipal.Show();
                            }
                            this.Hide();
                        }
                        else
                        {
                            reader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            TBMdp.PasswordChar = '*';
        }
    }
}

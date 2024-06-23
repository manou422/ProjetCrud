using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace ProjetCrud
{
    public partial class Login : Form
    {

        DBConnection LaConnexion = new DBConnection();
        private int clickCount = 0;
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
            string query = "SELECT idu,prenom,mail,mdp,admin,statut FROM utilisateurs WHERE mail = @mail AND mdp = @mdp";
            string query2 = "INSERT INTO connexion (idc,idu,dateConnexion,echec) values (null,@idu,@dateConnexion,@echec);";
            string queryRecherche = "SELECT idu,prenom,mail,mdp,admin,statut FROM utilisateurs WHERE mail = @mail";

            int id = 0;


            if (LaConnexion.IsConnect())
            {

                using (MySqlCommand cmd = new MySqlCommand(query, LaConnexion.Connection))
                {
                    cmd.Parameters.AddWithValue("@mail", TBMail.Text);
                    cmd.Parameters.AddWithValue("@mdp", Crypto.HasherMotDePasse(TBMdp.Text));

                    MySqlDataReader reader = cmd.ExecuteReader();


                    int rowCount = 0;
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["idu"]);
                        rowCount++;
                    }
                    reader.Close();
                    reader = cmd.ExecuteReader();
                    reader.Read();

                    if (rowCount == 1 && (string)reader["statut"] == "actif")
                    {
                        String prenom = (string)reader["prenom"];
                        int admin = Convert.ToInt32(reader["admin"]);
                        reader.Close();

                        using (MySqlCommand command = new MySqlCommand(query2, LaConnexion.Connection))
                        {
                            command.Parameters.AddWithValue("@idu", id);
                            command.Parameters.AddWithValue("@dateConnexion", DateTime.Now);
                            command.Parameters.AddWithValue("@echec", 1);
                            command.ExecuteNonQuery();
                        }

                        if (admin == 1)
                            {
                                Form1 formPrincipal = new Form1(LaConnexion, prenom);
                                formPrincipal.Show();
                            }
                            else if (admin == 0)
                            {
                                FormOperateur formPrincipal = new FormOperateur(LaConnexion, prenom);
                                formPrincipal.Show();
                            }
                            this.Hide();
                    }
                    else if (rowCount == 1 && (string)reader["statut"] == "archivé")
                    {
                        reader.Close();
                        MessageBox.Show("Votre compte a été archivé");
                        
                    }
                    else
                    {
                        if(rowCount == 0)
                        {
                            
                            using (MySqlCommand cmdRecherche = new MySqlCommand(queryRecherche, LaConnexion.Connection))
                            {
                                cmdRecherche.Parameters.AddWithValue("@mail", TBMail.Text);
                                reader.Close();

                                reader = cmdRecherche.ExecuteReader();
                                int rowCountRecherche = 0;
                                while (reader.Read())
                                {
                                    id = Convert.ToInt32(reader["idu"]);
                                    rowCountRecherche++;
                                }
                                reader.Close();

                                if(rowCountRecherche == 1)
                                {
                                    using (MySqlCommand command = new MySqlCommand(query2, LaConnexion.Connection))
                                    {
                                        command.Parameters.AddWithValue("@idu", id);
                                        command.Parameters.AddWithValue("@dateConnexion", DateTime.Now);
                                        command.Parameters.AddWithValue("@echec", 0);
                                        command.ExecuteNonQuery();
                                    }
                                }
                            }
                            MessageBox.Show("Mail ou mot de passe invalide");
                        }
                    }
                }
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {
            TBMdp.PasswordChar = '*';
        }

        private void quit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

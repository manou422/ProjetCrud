using MySql.Data.MySqlClient;
using Test_projet;

namespace Projet_BTS2
{
    public partial class Form1 : Form
    {

        DBConnection LaConnexion;
        public Form1(DBConnection connect, String n)
        {
            InitializeComponent();
            LaConnexion = connect;
            LBWelcome.Text = "Bienvenue " + n;

        }

        //private void BTConnect_Click(object sender, EventArgs e)
        //{
        //    LaConnexion.Server = "localhost";
        //    LaConnexion.DatabaseName = "Sucrerie";
        //    LaConnexion.UserName = "root";
        //    LaConnexion.Password = Crypto.Decrypt("xJdhnrU7njlOqo2QusEkwQ==");

        //    if (LaConnexion.IsConnect())
        //    {
        //        TBConnect.Text = "est connecté";
        //    }
        //    else
        //    {
        //        TBConnect.Text = "Problème de connexion";
        //    }
        //}

        private void BTAdd_Click(object sender, EventArgs e)
        {

                Utilisateur utilisateur = new Utilisateur();
                FormUtilisateur fu = new FormUtilisateur(utilisateur, LaConnexion);

                DialogResult result = fu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string query = "SELECT * FROM utilisateurs where idu > 0";
                    var cmd = new MySqlCommand(query, LaConnexion.Connection);
                    LaConnexion.Connection.Open();
                    var reader = cmd.ExecuteReader();
                    List<Utilisateur> users = new List<Utilisateur>();

                    while (reader.Read())
                    {
                        try
                        {
                            Utilisateur user = new Utilisateur
                            {
                                ContactId = (int)reader["idu"],
                                ContactNom = (string)reader["nom"],
                                ContactPrenom = (string)reader["prenom"],
                                ContactMail = (string)reader["mail"],
                                ContactMdp = (string)reader["mdp"],
                                ContactAdmin = (int)reader["admin"]
                            };
                            users.Add(user);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    reader.Close();
                    DGVUser.DataSource = users;
                    DGVUser.Columns["ContactId"].Visible = false;
                }
                else if (result == DialogResult.Cancel)
                {
                Close();
                }
            
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            if (DGVUser.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DGVUser.SelectedRows[0];
                Utilisateur selectedClient = (Utilisateur)row.DataBoundItem;
                FormUtilisateur formUser = new FormUtilisateur(selectedClient, LaConnexion);

                DialogResult result = formUser.ShowDialog();
                // Traitez le résultat en fonction du bouton sur lequel l'utilisateur a cliqué
                if (result == DialogResult.OK)
                {
                    string query = "SELECT * FROM utilisateurs where idu > 0";
                    var cmd = new MySqlCommand(query, LaConnexion.Connection);
                    var reader = cmd.ExecuteReader();
                    List<Utilisateur> users = new List<Utilisateur>();

                    while (reader.Read())
                    {
                        try
                        {
                            Utilisateur user = new Utilisateur
                            {
                                ContactId = (int)reader["idu"],
                                ContactNom = (string)reader["nom"],
                                ContactPrenom = (string)reader["prenom"],
                                ContactMail = (string)reader["mail"],
                                ContactMdp = (string)reader["mdp"],
                                ContactAdmin = (int)reader["admin"]
                            };
                            users.Add(user);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    reader.Close();
                    DGVUser.DataSource = users;
                    DGVUser.Columns["ContactId"].Visible = false;
                }
                else if (result == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            if (DGVUser.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DGVUser.SelectedRows[0];
                Utilisateur selectedClient = (Utilisateur)row.DataBoundItem;
                ConfirmationDelete formUser = new ConfirmationDelete(selectedClient, LaConnexion);
                DialogResult result = formUser.ShowDialog();
                string query = "SELECT * FROM utilisateurs where idu > 0";
                var cmd = new MySqlCommand(query, LaConnexion.Connection);
                var reader = cmd.ExecuteReader();
                List<Utilisateur> users = new List<Utilisateur>();

                while (reader.Read())
                {
                    try
                    {
                        Utilisateur user = new Utilisateur
                        {
                            ContactId = (int)reader["idu"],
                            ContactNom = (string)reader["nom"],
                            ContactPrenom = (string)reader["prenom"],
                            ContactMail = (string)reader["mail"],
                            ContactMdp = (string)reader["mdp"],
                            ContactAdmin = (int)reader["admin"]
                        };
                        users.Add(user);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                reader.Close();
                DGVUser.DataSource = users;
                DGVUser.Columns["ContactId"].Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM utilisateurs where idu > 0";
            var cmd = new MySqlCommand(query, LaConnexion.Connection);
            var reader = cmd.ExecuteReader();
            List<Utilisateur> users = new List<Utilisateur>();

            while (reader.Read())
            {
                try
                {
                    Utilisateur user = new Utilisateur
                    {
                        ContactId = (int)reader["idu"],
                        ContactNom = (string)reader["nom"],
                        ContactPrenom = (string)reader["prenom"],
                        ContactMail = (string)reader["mail"],
                        ContactMdp = (string)reader["mdp"],
                        ContactAdmin = (int)reader["admin"]
                    };
                    users.Add(user);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            reader.Close();
            DGVUser.DataSource = users;
            DGVUser.Columns["ContactId"].Visible = false;
        }
    }
}
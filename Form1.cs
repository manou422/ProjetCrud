using MySql.Data.MySqlClient;
using ProjetCrud;

namespace ProjetCrud
{
    public partial class Form1 : Form
    {

        DBConnection LaConnexion;
        private string prenom;
        public Form1(DBConnection connect, String n)
        {
            InitializeComponent();
            LaConnexion = connect;
            prenom = n;

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
                            ContactAdmin = (int)reader["admin"],
                            ContactStatut = (string)reader["statut"]
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

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            if (DGVUser.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DGVUser.SelectedRows[0];
                Utilisateur selectedClient = (Utilisateur)row.DataBoundItem;
                FormUtilisateur formUser = new FormUtilisateur(selectedClient, LaConnexion);

                DialogResult result = formUser.ShowDialog();
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
                                ContactAdmin = (int)reader["admin"],
                                ContactStatut = (string)reader["statut"]
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
            } else
            {
                MessageBox.Show("Veuillez sélectionner une personne");
            }
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            if (DGVUser.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DGVUser.SelectedRows[0];
                Utilisateur selectedClient = (Utilisateur)row.DataBoundItem;
                if (selectedClient.ContactPrenom == prenom)
                {
                    MessageBox.Show("Vous essayez de vous auto suprimer");
                }
                else
                {
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
                                ContactAdmin = (int)reader["admin"],
                                ContactStatut = (string)reader["statut"]
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
            else
            {
                MessageBox.Show("Veuillez sélectionner une personne");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue " + prenom + " (admin)");
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
                        ContactAdmin = (int)reader["admin"],
                        ContactStatut = (string)reader["statut"]
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
            DGVUser.Columns["ContactMdp"].Visible = false;



        }

        private void BTArchive_Click(object sender, EventArgs e)
        {
            if (DGVUser.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DGVUser.SelectedRows[0];
                Utilisateur selectedClient = (Utilisateur)row.DataBoundItem;
                ConfirmationArchivage formUser = new ConfirmationArchivage(selectedClient, LaConnexion);
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
                            ContactAdmin = (int)reader["admin"],
                            ContactStatut = (string)reader["statut"]
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
            else
            {
                MessageBox.Show("Veuillez sélectionner une personne");
            }
        }

        private void BTDeconnect_Click(object sender, EventArgs e)
        {
            Login connexion = new Login();
            connexion.Show();
            this.Hide();
        }

        private void BTConnexion_Click(object sender, EventArgs e)
        {
            ConnexionUsers formUser = new ConnexionUsers(LaConnexion);
            formUser.Show();
        }

        private void quit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
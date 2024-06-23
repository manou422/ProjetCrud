using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetCrud
{
    public partial class ConnexionUsers : Form
    {
        DBConnection LaConnexion;
        public ConnexionUsers(DBConnection connexion)
        {
            InitializeComponent();
            LaConnexion = connexion;
        }

        private void ConnexionUsers_Load(object sender, EventArgs e)
        {
            string query = "SELECT connexion.idu,connexion.dateConnexion,utilisateurs.prenom FROM connexion INNER JOIN utilisateurs ON connexion.idu = utilisateurs.idu";

            List<Connexion> connexionUsers = new List<Connexion>();

            using (MySqlCommand cmd = new MySqlCommand(query, LaConnexion.Connection))
            {




                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        Connexion connect = new Connexion((int)reader["idu"], (string)reader["prenom"], (DateTime)reader["dateConnexion"]);
                        connexionUsers.Add(connect);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                reader.Close();
                DGVConnexion.DataSource = connexionUsers;
            }
        }

        private void BTValid_Click(object sender, EventArgs e)
        {
            string query = "SELECT connexion.idu,connexion.dateConnexion,utilisateurs.prenom FROM connexion INNER JOIN utilisateurs ON connexion.idu = utilisateurs.idu " +
                "WHERE DATE(DateConnexion) = date(@filtre)";

            List<Connexion> connexionUsers = new List<Connexion>();

            using (MySqlCommand cmd = new MySqlCommand(query, LaConnexion.Connection))
            {
                string dateFiltre = DateFiltre.Value.Year.ToString() + "-" + DateFiltre.Value.Month.ToString() + "-" + DateFiltre.Value.Day.ToString();
                cmd.Parameters.AddWithValue("@filtre", DateFiltre.Value);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        Connexion connect = new Connexion((int)reader["idu"], (string)reader["prenom"], (DateTime)reader["dateConnexion"]);
                        connexionUsers.Add(connect);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                reader.Close();
                DGVConnexion.DataSource = connexionUsers;
            }
        }

        private void BTFiltre_Click(object sender, EventArgs e)
        {
            string query = "SELECT utilisateurs.idu, utilisateurs.prenom, connexion.DateConnexion FROM connexion Right JOIN utilisateurs ON connexion.idu = utilisateurs.idu " +
                            "WHERE(connexion.DateConnexion between date_sub(NOW(), INTERVAL 5 DAY) AND NOW())";

            List<Connexion> connexionUsers = new List<Connexion>();

            using (MySqlCommand cmd = new MySqlCommand(query, LaConnexion.Connection))
            {

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        Connexion connect = new Connexion((int)reader["idu"], (string)reader["prenom"], (DateTime)reader["DateConnexion"]);
                        connexionUsers.Add(connect);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                reader.Close();
                DGVConnexion.DataSource = connexionUsers;
            }
        }

        private void BTVider_Click(object sender, EventArgs e)
        {
            DateFiltre.Value = DateTime.Now;
            string query = "SELECT connexion.idu,connexion.dateConnexion,utilisateurs.prenom FROM connexion INNER JOIN utilisateurs ON connexion.idu = utilisateurs.idu";

            List<Connexion> connexionUsers = new List<Connexion>();

            using (MySqlCommand cmd = new MySqlCommand(query, LaConnexion.Connection))
            {




                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        Connexion connect = new Connexion((int)reader["idu"], (string)reader["prenom"], (DateTime)reader["dateConnexion"]);
                        connexionUsers.Add(connect);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                reader.Close();
                DGVConnexion.DataSource = connexionUsers;
            }
        }
    }
}

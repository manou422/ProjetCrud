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

namespace ProjetCrud
{
    public partial class FormOperateur : Form
    {
        DBConnection LaConnexion;
        string prenom;
        public FormOperateur(DBConnection connect, String n)
        {
            InitializeComponent();
            LaConnexion = connect;
            prenom = n;

        }
        
        private void FormOperateur_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue " + prenom + " (opérateur)");
            string query = "SELECT Identifiant, Editeur, notice_bnf, titre, auteur FROM livres limit 30";
            List<livre> livres = new List<livre>();

            using (MySqlCommand cmd = new MySqlCommand(query, LaConnexion.Connection))
            {




                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        livre newLivre = new livre((string)reader["Identifiant"], (int)reader["notice_Bnf"], "", "", "", 0, (string)reader["Titre"], (string)reader["Auteur"], "", (string)reader["Editeur"], 0, "", "", "", "", "");
                        livres.Add(newLivre);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                reader.Close();
                DGVLivres.DataSource = livres;
                DGVLivres.Columns["Identifiant"].Width = 320;
                DGVLivres.Columns["Type_notice"].Visible = false;
                DGVLivres.Columns["Type_Document"].Visible = false;
                DGVLivres.Columns["Localisation"].Visible = false;
                DGVLivres.Columns["Num_exemplaire"].Visible = false;
                DGVLivres.Columns["Contributeur"].Visible = false;
                DGVLivres.Columns["Date"].Visible = false;
                DGVLivres.Columns["Description"].Visible = false;
                DGVLivres.Columns["Sujet"].Visible = false;
                DGVLivres.Columns["Couverture"].Visible = false;
                DGVLivres.Columns["Langue"].Visible = false;
                DGVLivres.Columns["Format"].Visible = false;
            }
        }

        private void BTConsulter_Click(object sender, EventArgs e)
        {
            if (DGVLivres.SelectedRows.Count != 0)
            {
                DataGridViewRow row = DGVLivres.SelectedRows[0];
                livre selectedLivre = (livre)row.DataBoundItem;
                LivreConsulter formlivre = new LivreConsulter(selectedLivre, LaConnexion);
                formlivre.ShowDialog();
            } else
            {
                MessageBox.Show("Veuillez sélectionner un livre");
            }
        }

        private void quit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

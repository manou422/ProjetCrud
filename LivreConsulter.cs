using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class LivreConsulter : Form
    {
        private livre livreCourant;
        DBConnection LaConnexion;
        public LivreConsulter(livre l, DBConnection connect)
        {
            InitializeComponent();
            LaConnexion = connect;
            livreCourant = l;
        }

        private void LivreConsulter_Load(object sender, EventArgs e)
        {
            string req = "SELECT * FROM livres WHERE Identifiant = @id";
            List<livre> livres = new List<livre>();
            using (MySqlCommand cmd = new MySqlCommand(req, LaConnexion.Connection))
            {
                cmd.Parameters.AddWithValue("@id", livreCourant.identifiant);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        livre newLivre = new livre((string)reader["Identifiant"], (int)reader["Notice_Bnf"], (string)reader["Type_notice"], (string)reader["Type_document"], (string)reader["Localisation"], (int)reader["Num_exemplaire"], (string)reader["Titre"], (string)reader["Auteur"], (string)reader["Contributeur"], (string)reader["Editeur"], (int)reader["Date"], (string)reader["Description"], (string)reader["Sujet"], (string)reader["Couverture"], (string)reader["Langue"], (string)reader["Format"]);
                        TBAuteur.Text = newLivre.auteur;
                        TBContributeur.Text = newLivre.contributeur;
                        TBCouverture.Text = newLivre.couverture;
                        TBDate.Text = newLivre.date.ToString();
                        TBDescription.Text = (string)newLivre.description;
                        TBEditeur.Text = (string)newLivre.description;
                        TBFormat.Text = (string)newLivre.format;
                        TBIdentifiant.Text = (string)newLivre.identifiant;
                        TBLangue.Text = (string)newLivre.langue;
                        TBLocalisation.Text = (String)newLivre.localisation;
                        TBNoticeBnf.Text = newLivre.notice_Bnf.ToString();
                        TBNumExemplaire.Text = newLivre.num_exemplaire.ToString();
                        TBSujet.Text = (string)newLivre.sujet;
                        TBTitre.Text = (string)newLivre.titre;
                        TBTypeDocument.Text = (string)newLivre.type_document;
                        TBTypeNotice.Text = (string)newLivre.type_notice;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                reader.Close();
            }
        }
    }
}

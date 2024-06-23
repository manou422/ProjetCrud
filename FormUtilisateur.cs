
namespace ProjetCrud
{
    public partial class FormUtilisateur : Form
    {
        Utilisateur utilisateurCourant;
        DBConnection connectGlobale;
        public FormUtilisateur(Utilisateur uCourant, DBConnection connexion)
        {
            InitializeComponent();
            utilisateurCourant = uCourant;
            connectGlobale = connexion;
            TBNom.Text = uCourant.ContactNom;
            TBPrenom.Text = uCourant.ContactPrenom;
            TBMail.Text = uCourant.ContactMail;
            TBAdmin.Text = uCourant.ContactAdmin.ToString();
        }

        private void FormUtilisateur_Load(object sender, EventArgs e)
        {
            if (utilisateurCourant.ContactPrenom == null)
            {
                LBMdp.Visible = true;
                TBMdp.Visible = true;
                BTChangeMDP.Visible = false;
            }
            else
            {
                LBMdp.Visible = false;
                TBMdp.Visible = false;
                BTChangeMDP.Visible = true;

            }
        }

        private void BTOk_Click(object sender, EventArgs e)
        {
            if (TBMail.Text == "")
            {
                MessageBox.Show("Veuillez saisir un mail");
            }
            else if (TBMdp.Text == "" && (LBMdp.Visible && TBMdp.Visible))
            {
                MessageBox.Show("Veuillez saisir un mot de passe");
            }
            else if (int.Parse(TBAdmin.Text) != 0 && int.Parse(TBAdmin.Text) != 1)
            {
                MessageBox.Show("Veuillez saisir 0 pour l'opérateur ou 1 pour l'administrateur");
            }
            else
            {
                utilisateurCourant.ContactNom = TBNom.Text;
                utilisateurCourant.ContactPrenom = TBPrenom.Text;
                utilisateurCourant.ContactMail = TBMail.Text;
                utilisateurCourant.ContactMdp = TBMdp.Text;
                utilisateurCourant.ContactAdmin = int.Parse(TBAdmin.Text);
                utilisateurCourant.save(connectGlobale);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BTChangeMDP_Click(object sender, EventArgs e)
        {
            LBMdp.Visible = true;
            TBMdp.Visible = true;
            TBMdp.PasswordChar = '*';
        }

        private void BTAnnuler_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

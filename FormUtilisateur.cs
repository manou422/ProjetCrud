using Projet_BTS2;

namespace Test_projet
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
        }

        private void FormUtilisateur_Load(object sender, EventArgs e)
        {
            LBMdp.Visible = false;
            TBMdp.Visible = false;
        }

        private void BTOk_Click(object sender, EventArgs e)
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

        private void BTChangeMDP_Click(object sender, EventArgs e)
        {
            LBMdp.Visible = true;
            TBMdp.Visible = true;
            TBMdp.PasswordChar = '*';
        }


        private void BTAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

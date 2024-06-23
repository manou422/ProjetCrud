
namespace ProjetCrud
{
    public partial class ConfirmationDelete : Form
    {

        Utilisateur utilisateurCourant;
        DBConnection connectGlobale;
        public ConfirmationDelete(Utilisateur user, DBConnection connect)
        {
            InitializeComponent();
            utilisateurCourant = user;
            connectGlobale = connect;
        }

        private void BTOui_Click(object sender, EventArgs e)
        {
            utilisateurCourant.delete(connectGlobale);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BTNon_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

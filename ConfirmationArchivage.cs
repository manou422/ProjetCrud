using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ConfirmationArchivage : Form
    {

        Utilisateur utilisateurCourant;
        DBConnection connectGlobale;
        public ConfirmationArchivage(Utilisateur user, DBConnection connect)
        {
            InitializeComponent();
            utilisateurCourant = user;
            connectGlobale = connect;
        }

        private void BTOui_Click(object sender, EventArgs e)
        {
            utilisateurCourant.archivage(connectGlobale);
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

using Projet_BTS2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_projet
{
    public partial class FormOperateur : Form
    {
        DBConnection LaConnexion;
        public FormOperateur(DBConnection connect, String n)
        {
            InitializeComponent();
            LaConnexion = connect;
            LBWelcome.Text = "Bienvenue " + n;

        }

        private void FormOperateur_Load(object sender, EventArgs e)
        {

        }
    }
}

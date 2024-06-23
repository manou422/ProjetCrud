using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCrud
{
    internal class Connexion
    {
        public int idu { get; set; }
        public string prenom { get; set; }
        public DateTime date { get; set; }
        public Connexion(int idu, string p, DateTime d) {
            this.idu = idu;
            prenom = p;
            date = d;
        }
    }
}

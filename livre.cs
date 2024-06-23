using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetCrud
{
    public class livre
    {
        public string identifiant {  get; set; }
        public int notice_Bnf { get; set; }
        public string type_notice { get; set; }
        public string type_document { get; set; }
        public string localisation {  get; set; }
        public int num_exemplaire { get; set; }
        public string titre { get; set; }
        public string auteur { get; set; }
        public string contributeur {  get; set; }
        public string editeur { get; set; }
        public int date {  get; set; }
        public string description {  get; set; }
        public string sujet { get; set; }
        public string couverture { get; set; }
        public string langue { get; set; }
        public string format { get; set; }

        public livre(string i, int nb, string tn, string td, string l, int ne, string t, string a, string c, string e, int d, string des, string s, string couv, string lan, string f)
        {
            identifiant = i;
            notice_Bnf = nb;
            type_notice = tn;
            type_document = td;
            localisation = l;
            num_exemplaire = ne;
            titre = t;
            auteur = a;
            contributeur = c;
            editeur = e;
            date = d;
            description = des;
            sujet = s;
            couverture = couv;
            langue = lan;
            format = f;
        }
    }
}

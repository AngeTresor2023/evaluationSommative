using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluation_sommative3
{
    public class Cours
    {
        private double numeroCours;
        private string code, titre; 
        public Cours (string code, string titre, double numeroCours)
        {
            this.code = code;
            this.titre = titre;
            this.numeroCours = numeroCours;
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }
        public double NumeroCours
        {
            get { return numeroCours; }
            set { numeroCours = value; }
        }

    }
 
}

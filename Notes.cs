using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluation_sommative3
{
    public class Notes
    {
        private double numeroEtudiant, numeroCours, note;

        public Notes(double numeroCours, double note, double numeroEtudiant)
        {
            this.numeroEtudiant = numeroEtudiant;
            this.numeroCours = numeroCours;
            this.note = note;
        }
        public double Note
        {
            get { return note; }
            set { note = value; }
        }
        public double NumeroCours
        {
            get { return numeroCours; }
            set { numeroCours = value; }
        }
        public double NumeroEtudiant
        {
            get { return numeroEtudiant; }
            set { numeroEtudiant = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluation_sommative3
{
    public class Etudiant
    {
            private double numeroEtudiant;
            private string nom, prenom;
            public Etudiant (double numeroEtudiant, string prenom, string nom)
            {
                this.numeroEtudiant = numeroEtudiant;
                this.nom = nom;
                this.prenom = prenom;
            }
            public string Nom
            {
                get { return nom; }
                set { nom = value; }
            }
            public string Prenom
            {
                get { return prenom; }
                set { prenom = value; }
            }
            public double NumeroEtudiant
            {
                get { return numeroEtudiant; }
                set { numeroEtudiant = value; }
            }

    }
}

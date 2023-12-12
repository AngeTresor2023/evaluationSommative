using evaluation_sommative3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Création d'instances d'étudiants, de cours et de notes
        Etudiant etudiant1 = new Etudiant( 1, "Dupont", "Jean" );
        Cours cours1 = new Cours ("CS101","Introduction à l'informatique",101 );
        Notes note1 = new Notes (101, 85, 1 );

        // Accès aux attributs des instances créées
        Console.WriteLine($"Étudiant : {etudiant1.Nom} {etudiant1.Prenom}");
        Console.WriteLine($"Cours : {cours1.Code} - {cours1.Titre}");
        Console.WriteLine($"Note de l'étudiant 1 pour le cours 1 : {note1.Note}");
    }
}

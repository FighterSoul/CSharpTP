// See https://aka.ms/new-console-template for more information
using System;

namespace TD1
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne[] personnes = new Personne[8];

            personnes[0] = new Employe("Dupont", "Jean", new DateTime(1990, 5, 23), 3000);
            personnes[1] = new Employe("Martin", "Paul", new DateTime(1985, 3, 15), 3200);
            personnes[2] = new Employe("Durand", "Sophie", new DateTime(1992, 7, 10), 3100);
            personnes[3] = new Employe("Lefevre", "Marie", new DateTime(1988, 11, 5), 3300);
            personnes[4] = new Employe("Moreau", "Luc", new DateTime(1995, 1, 20), 2900);

            personnes[5] = new Chef("Bernard", "Alice", new DateTime(1980, 9, 25), 4000, "Informatique");
            personnes[6] = new Chef("Petit", "Julien", new DateTime(1975, 4, 30), 4200, "Marketing");

            personnes[7] = new Directeur("Roux", "Claire", new DateTime(1970, 12, 15), 5000, "Direction", "TechCorp");

            Console.WriteLine("Affichage avec for:");
            for (int i = 0; i < personnes.Length; i++)
            {
                personnes[i].Afficher();
                Console.WriteLine();
            }

            Console.WriteLine("Affichage avec foreach:");
            foreach (var personne in personnes)
            {
                personne.Afficher();
                Console.WriteLine();
            }
        }
    }
}

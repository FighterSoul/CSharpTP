using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1EX2
{
    internal class Employe
    {
        public int Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public DateTime DateEmbauche { get; set; }
        public decimal Salaire { get; set; }

        public Employe()
        {
            Console.Write("Entrez le matricule: ");
            Matricule = int.Parse(Console.ReadLine());

            Console.Write("Entrez le nom: ");
            Nom = Console.ReadLine();

            Console.Write("Entrez le prénom: ");
            Prenom = Console.ReadLine();

            Console.Write("Entrez la date de naissance (yyyy-mm-dd): ");
            DateNaissance = DateTime.Parse(Console.ReadLine());

            Console.Write("Entrez la date d'embauche (yyyy-mm-dd): ");
            DateEmbauche = DateTime.Parse(Console.ReadLine());

            Console.Write("Entrez le salaire: ");
            Salaire = decimal.Parse(Console.ReadLine());
        }

        public int Age()
        {
            var today = DateTime.Today;
            var age = today.Year - DateNaissance.Year;
            if (DateNaissance.Date > today.AddYears(-age)) age--;
            return age;
        }

        public int Anciennete()
        {
            var today = DateTime.Today;
            var anciennete = today.Year - DateEmbauche.Year;
            if (DateEmbauche.Date > today.AddYears(-anciennete)) anciennete--;
            return anciennete;
        }

        public void AugmentationDuSalaire()
        {
            int anciennete = Anciennete();
            if (anciennete < 5)
            {
                Salaire *= 1.02m;
            }
            else if (anciennete < 10)
            {
                Salaire *= 1.05m;
            }
            else
            {
                Salaire *= 1.10m;
            }
        }

        public void AfficherEmploye()
        {
            Console.WriteLine($"-Matricule: |{Matricule}|");
            Console.WriteLine($"-Nom complet: |{Nom.ToUpper()} {Prenom}|");
            Console.WriteLine($"-Age: |{Age()}|");
            Console.WriteLine($"-Anciennete: |{Anciennete()}|");
            Console.WriteLine($"-Salaire: |{Salaire:C}|");
        }
    }
}


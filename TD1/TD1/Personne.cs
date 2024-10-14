using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    internal class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }

        public Personne(string nom, string prenom, DateTime dateDeNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateDeNaissance = dateDeNaissance;
        }

        public virtual void Afficher()
        {
            Console.WriteLine($"Nom: {Nom}, Prénom: {Prenom}, Date de Naissance: {DateDeNaissance.ToShortDateString()}");
        }
    }
}

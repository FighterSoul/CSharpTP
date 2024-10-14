using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    internal class Employe : Personne
    {
        public decimal Salaire { get; set; }

        public Employe(string nom, string prenom, DateTime dateDeNaissance, decimal salaire)
            : base(nom, prenom, dateDeNaissance)
        {
            Salaire = salaire;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Salaire: {Salaire:C}");
        }
    }
}

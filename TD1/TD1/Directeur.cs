using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    internal class Directeur : Chef
    {
        public string Societe { get; set; }

        public Directeur(string nom, string prenom, DateTime dateDeNaissance, decimal salaire, string service, string societe)
            : base(nom, prenom, dateDeNaissance, salaire, service)
        {
            Societe = societe;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Société: {Societe}");
        }
    }
}


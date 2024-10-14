using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    internal class Chef : Employe
    {
        public string Service { get; set; }

        public Chef(string nom, string prenom, DateTime dateDeNaissance, decimal salaire, string service)
            : base(nom, prenom, dateDeNaissance, salaire)
        {
            Service = service;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Service: {Service}");
        }
    }
}


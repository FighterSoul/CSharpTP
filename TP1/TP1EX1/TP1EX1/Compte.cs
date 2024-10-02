using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1EX1
{
    internal class Compte
    {
        private static int _codeCounter = 0;
        public int Code { get; }
        public double Solde { get; private set; }
        public Client Proprietaire { get; set; }

        public Compte(double solde, Client proprietaire)
        {
            Code = ++_codeCounter;
            Solde = solde;
            Proprietaire = proprietaire;
        }

        public Compte(Client proprietaire)
        {
            Code = ++_codeCounter;
            Solde = 0;
            Proprietaire = proprietaire;
        }

        public void Crediter(double somme)
        {
            if (somme > 0)
            {
                Solde += somme;
            }
        }

        public void Crediter(double somme, Compte autreCompte)
        {
            if (somme > 0 && autreCompte.Solde >= somme)
            {
                Solde += somme;
                autreCompte.Solde -= somme;
            }
        }

        public void Debiter(double somme)
        {
            if (somme > 0 && Solde >= somme)
            {
                Solde -= somme;
            }
        }

        public void Debiter(double somme, Compte autreCompte)
        {
            if (somme > 0 && Solde >= somme)
            {
                Solde -= somme;
                autreCompte.Crediter(somme);
            }
        }

        public void AfficherResume()
        {
            Console.WriteLine($"Code: {Code}");
            Console.WriteLine($"Solde: {Solde}");
            Proprietaire.Afficher();
        }

        public static void AfficherNombreComptes()
        {
            Console.WriteLine($"Nombre de comptes créés: {_codeCounter}");
        }
    }
}




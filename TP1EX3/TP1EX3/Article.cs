using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1EX3
{
    internal class Article
    {
        private string référence;
        private string désignation;
        private decimal prixHT;
        private static decimal tauxTVA;

        public string Référence
        {
            get { return référence; }
            set { référence = value; }
        }

        public string Désignation
        {
            get { return désignation; }
            set { désignation = value; }
        }

        public decimal PrixHT
        {
            get { return prixHT; }
            set { prixHT = value; }
        }

        public static decimal TauxTVA
        {
            get { return tauxTVA; }
            set { tauxTVA = value; }
        }

        public Article()
        {
        }

        public Article(string référence, string désignation, decimal prixHT)
        {
            this.référence = référence;
            this.désignation = désignation;
            this.prixHT = prixHT;
        }

        public Article(string référence, string désignation)
        {
            this.référence = référence;
            this.désignation = désignation;
        }

        public Article(Article autre)
        {
            this.référence = autre.référence;
            this.désignation = autre.désignation;
            this.prixHT = autre.prixHT;
        }

        public decimal CalculerPrixTTC()
        {
            return PrixHT + (PrixHT * TauxTVA / 100);
        }

        public void AfficherArticle()
        {
            Console.WriteLine($"Référence : {Référence}");
            Console.WriteLine($"Désignation : {Désignation}");
            Console.WriteLine($"Prix HT : {PrixHT}");
            Console.WriteLine($"Le prix TTC est {CalculerPrixTTC()}");
        }
    }

}



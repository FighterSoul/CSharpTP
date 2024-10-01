using System;

namespace TP1EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe = new Employe();

            employe.AfficherEmploye();

            employe.AugmentationDuSalaire();

            Console.WriteLine("\nAprès augmentation du salaire:");
            employe.AfficherEmploye();
        }
    }
}


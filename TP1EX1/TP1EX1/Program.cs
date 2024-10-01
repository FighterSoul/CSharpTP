using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("EE111222", "Salim", "Omar", "0611111");
            Client client2 = new Client("EE333444", "Karimi", "Samir");

            Compte compte1 = new Compte(1000.0, client1);
            Compte compte2 = new Compte(500.0, client2);

            Console.WriteLine("Résumé du compte 1:");
            compte1.AfficherResume();
            Console.WriteLine("************************");

            Console.WriteLine("Résumé du compte 2:");
            compte2.AfficherResume();
            Console.WriteLine("************************");

            Console.WriteLine("Opérations sur le compte 1:");
            compte1.Crediter(200);
            Console.WriteLine("Après crédit de 200:");
            compte1.AfficherResume();
            Console.WriteLine("************************");

            compte1.Debiter(100);
            Console.WriteLine("Après débit de 100:");
            compte1.AfficherResume();
            Console.WriteLine("************************");

            Console.WriteLine("Opérations entre compte 1 et compte 2:");
            compte1.Crediter(100, compte2);
            Console.WriteLine("Après crédit de 100 du compte 2 au compte 1:");
            compte1.AfficherResume();
            compte2.AfficherResume();
            Console.WriteLine("************************");

            compte1.Debiter(50, compte2);
            Console.WriteLine("Après débit de 50 du compte 1 au compte 2:");
            compte1.AfficherResume();
            compte2.AfficherResume();
            Console.WriteLine("************************");

            Compte.AfficherNombreComptes();
        }
    }
}

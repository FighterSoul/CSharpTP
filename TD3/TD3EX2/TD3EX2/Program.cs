namespace TD3EX2
{
    using System;
    using System.Collections.Generic;

    public class MontantInvalideException : Exception
    {
        public MontantInvalideException(string message) : base(message) { }
    }

    public class SoldeInsuffisantException : Exception
    {
        public SoldeInsuffisantException(string message) : base(message) { }
    }

    public class CompteNonTrouveException : Exception
    {
        public CompteNonTrouveException(string message) : base(message) { }
    }

    public class CompteBancaire
    {
        public int Id { get; private set; }
        public string NomTitulaire { get; private set; }
        public decimal Solde { get; private set; }

        public CompteBancaire(int id, string nomTitulaire, decimal soldeInitial)
        {
            Id = id;
            NomTitulaire = nomTitulaire;
            Solde = soldeInitial;
        }

        public void Deposer(decimal montant)
        {
            if (montant < 0)
                throw new MontantInvalideException("Le montant déposé doit être positif.");
            Solde += montant;
        }

        public void Retirer(decimal montant)
        {
            if (montant < 0)
                throw new MontantInvalideException("Le montant retiré doit être positif.");
            if (montant > Solde)
                throw new SoldeInsuffisantException("Solde insuffisant pour effectuer le retrait.");
            Solde -= montant;
        }

        public void AfficherSolde()
        {
            Console.WriteLine($"Compte {Id} - Solde : {Solde:C}");
        }
    }

    public class Banque
    {
        private List<CompteBancaire> comptes = new List<CompteBancaire>();

        public void AjouterCompte(CompteBancaire compte)
        {
            comptes.Add(compte);
        }

        public CompteBancaire RechercherCompte(int id)
        {
            var compte = comptes.Find(c => c.Id == id);
            if (compte == null)
                throw new CompteNonTrouveException($"Aucun compte trouvé avec l'ID {id}.");
            return compte;
        }

        public void Transfert(int idSource, int idDestination, decimal montant)
        {
            if (montant < 0)
                throw new MontantInvalideException("Le montant transféré doit être positif.");

            var compteSource = RechercherCompte(idSource);
            var compteDestination = RechercherCompte(idDestination);

            compteSource.Retirer(montant);
            compteDestination.Deposer(montant);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Banque banque = new Banque();

            try
            {
                // Menu interactif
                while (true)
                {
                    Console.WriteLine("\n=== Menu ===");
                    Console.WriteLine("1. Ajouter un compte");
                    Console.WriteLine("2. Consulter un solde");
                    Console.WriteLine("3. Déposer de l'argent");
                    Console.WriteLine("4. Retirer de l'argent");
                    Console.WriteLine("5. Transférer des fonds");
                    Console.WriteLine("6. Quitter");
                    Console.Write("Votre choix : ");
                    int choix = int.Parse(Console.ReadLine());

                    switch (choix)
                    {
                        case 1:
                            Console.Write("ID du compte : ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Nom du titulaire : ");
                            string nom = Console.ReadLine();
                            Console.Write("Solde initial : ");
                            decimal soldeInitial = decimal.Parse(Console.ReadLine());
                            banque.AjouterCompte(new CompteBancaire(id, nom, soldeInitial));
                            Console.WriteLine("Compte ajouté avec succès.");
                            break;

                        case 2:
                            Console.Write("ID du compte : ");
                            id = int.Parse(Console.ReadLine());
                            var compte = banque.RechercherCompte(id);
                            compte.AfficherSolde();
                            break;

                        case 3:
                            Console.Write("ID du compte : ");
                            id = int.Parse(Console.ReadLine());
                            Console.Write("Montant à déposer : ");
                            decimal montant = decimal.Parse(Console.ReadLine());
                            compte = banque.RechercherCompte(id);
                            compte.Deposer(montant);
                            Console.WriteLine("Montant déposé avec succès.");
                            break;

                        case 4:
                            Console.Write("ID du compte : ");
                            id = int.Parse(Console.ReadLine());
                            Console.Write("Montant à retirer : ");
                            montant = decimal.Parse(Console.ReadLine());
                            compte = banque.RechercherCompte(id);
                            compte.Retirer(montant);
                            Console.WriteLine("Montant retiré avec succès.");
                            break;

                        case 5:
                            Console.Write("ID du compte source : ");
                            int idSource = int.Parse(Console.ReadLine());
                            Console.Write("ID du compte destination : ");
                            int idDestination = int.Parse(Console.ReadLine());
                            Console.Write("Montant à transférer : ");
                            montant = decimal.Parse(Console.ReadLine());
                            banque.Transfert(idSource, idDestination, montant);
                            Console.WriteLine("Transfert effectué avec succès.");
                            break;

                        case 6:
                            return;

                        default:
                            Console.WriteLine("Choix invalide.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }
    }
}

namespace TP1EX1
{
    public class Client
    {
        private string CIN { get; set; }
        private string Nom { get; set; }
        private string Prenom { get; set; }
        private string Tel { get; set; }


        public Client(string cin, string nom, string prenom, string tel)
        {
            CIN = cin;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
        }
        public Client(string cin, string nom, string prenom)
        {
            CIN = cin;
            Nom = nom;
            Prenom = prenom;
        }


        public void Afficher()
        {
            Console.WriteLine($"CIN: {CIN}");
            Console.WriteLine($"Nom: {Nom}");
            Console.WriteLine($"Prenom: {Prenom}");
            if (!string.IsNullOrEmpty(Tel))
            {
                Console.WriteLine($"Tel: {Tel}");
            }
        }
    }
}


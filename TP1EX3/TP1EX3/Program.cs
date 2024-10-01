using TP1EX3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Donner le taux de TVA pour tous les articles : ");
        Article.TauxTVA = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"Le taux TVA est : {Article.TauxTVA}%");

        Console.WriteLine("Article 1:");
        Article article1 = new Article();
        article1.AfficherArticle();

        Console.WriteLine();

        Console.WriteLine("Article 2:");
        Console.Write("Donner la référence: ");
        string ref2 = Console.ReadLine();
        Console.Write("Donner la désignation: ");
        string des2 = Console.ReadLine();
        Console.Write("Donner le prix HT: ");
        decimal prixHT2 = decimal.Parse(Console.ReadLine());
        Article article2 = new Article(ref2, des2, prixHT2);
        article2.AfficherArticle();

        Console.WriteLine();

        // Article 3
        Console.WriteLine("Article 3:");
        Console.Write("Donner la référence: ");
        string ref3 = Console.ReadLine();
        Console.Write("Donner la désignation: ");
        string des3 = Console.ReadLine();
        Article article3 = new Article(ref3, des3);
        article3.AfficherArticle();

        Console.WriteLine();

        Console.WriteLine("Article 4:");
        Article article4 = new Article(article2);
        article4.AfficherArticle();
    }
}

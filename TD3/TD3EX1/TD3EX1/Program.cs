namespace TD3EX1
{
    using System;


    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Entrez le premier nombre : ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Entrez le deuxième nombre : ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("Entrez l'opération (+, -, *, /) : ");
                char operation = Console.ReadLine()[0];

                int resultat = Calculatrice.Calculer(a, b, operation);
                Console.WriteLine($"Résultat : {resultat}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Veuillez entrer des nombres entiers.");
            }
            catch (OperationInvalideException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Fin de l'opération.");
            }
        }
    }
}

namespace TD3EX1
{
    using System;

    public class OperationInvalideException : Exception
    {
        public OperationInvalideException(string message) : base(message) { }
    }

    public class Calculatrice
    {
        public static int Calculer(int a, int b, char operation)
        {
            return operation switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' when b == 0 => throw new DivideByZeroException("Division par zéro impossible."),
                '/' => a / b,
                _ => throw new OperationInvalideException("Opération non valide."),
            };
        }
    }
}
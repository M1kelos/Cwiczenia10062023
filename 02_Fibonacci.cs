using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę wyrazów do wygenerowania: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Ciąg Fibonacciego:");

        for (int i = 0; i < n; i++)
        {
            long wynik = Fibonacci(i);
            Console.WriteLine(wynik);
        }
    }

    static long Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        long fibNMinus2 = 0;
        long fibNMinus1 = 1;
        long fibN = 0;

        for (int i = 2; i <= n; i++)
        {
            fibN = fibNMinus1 + fibNMinus2;
            fibNMinus2 = fibNMinus1;
            fibNMinus1 = fibN;
        }

        return fibN;
    }
}
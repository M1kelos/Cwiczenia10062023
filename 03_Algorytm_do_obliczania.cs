using System;

class Program
{
    static void Main()
    {
        int n, k;

        do
        {
            Console.Write("Podaj liczbę n (n >= 5): ");
            n = int.Parse(Console.ReadLine());
        } while (n < 5);

        do
        {
            Console.Write("Podaj liczbę k (k >= 5): ");
            k = int.Parse(Console.ReadLine());
        } while (k < 5);

        long wynik = ObliczWyrazenie(n, k);
        Console.WriteLine($"Wynik: {wynik}");
    }

    static long ObliczWyrazenie(int n, int k)
    {
        long nSilnia = Silnia(n);
        long kSilnia = Silnia(k);

        long m = (nSilnia - kSilnia) / kSilnia;

        return m;
    }

    static long Silnia(int x)
    {
        long wynik = 1;

        for (int i = 2; i <= x; i++)
        {
            wynik *= i;
        }

        return wynik;
    }
}
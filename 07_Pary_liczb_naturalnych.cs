using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Pary liczb naturalnych o sumie równej {n}:");

        WypiszParyLiczbowe(n);
    }

    static void WypiszParyLiczbowe(int n)
    {
        for (int i = 1; i <= n / 2; i++)
        {
            int drugaLiczba = n - i;
            Console.WriteLine($"({i}, {drugaLiczba})");
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wartość x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę wyrazów n: ");
        int n = int.Parse(Console.ReadLine());

        double wynik = SzacujWartoscEx(x, n);
        Console.WriteLine($"Szacowana wartość e^{x} = {wynik}");
    }

    static double SzacujWartoscEx(double x, int n)
    {
        double suma = 0;

        for (int i = 0; i <= n; i++)
        {
            suma += Math.Pow(x, i) / ObliczSilnie(i);
        }

        return suma;
    }

    static double ObliczSilnie(int n)
    {
        double silnia = 1;

        for (int i = 2; i <= n; i++)
        {
            silnia *= i;
        }

        return silnia;
    }
}
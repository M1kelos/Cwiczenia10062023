using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj podstawę: ");
        int podstawa = int.Parse(Console.ReadLine());

        Console.Write("Podaj wykładnik: ");
        int wykladnik = int.Parse(Console.ReadLine());

        long wynik = Potegowanie(podstawa, wykladnik);
        Console.WriteLine($"Wynik potęgowania: {wynik}");
    }

    static long Potegowanie(int podstawa, int wykladnik)
    {
        long wynik = 1;

        for (int i = 0; i < wykladnik; i++)
        {
            wynik *= podstawa;
        }

        return wynik;
    }
}
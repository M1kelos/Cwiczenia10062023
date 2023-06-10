using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj kwotę początkową: ");
        decimal kwotaPoczatkowa = decimal.Parse(Console.ReadLine());

        Console.Write("Podaj oprocentowanie konta w skali roku: ");
        decimal oprocentowanie = decimal.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę miesięcy oszczędzania: ");
        int liczbaMiesiecy = int.Parse(Console.ReadLine());

        decimal kwotaKoncowa = ObliczKwoteZysku(kwotaPoczatkowa, oprocentowanie, liczbaMiesiecy);
        decimal podatekBelki = ObliczPodatekBelki(kwotaKoncowa);
        decimal kwotaKoncowaPoPodatku = kwotaKoncowa - podatekBelki;

        Console.WriteLine($"Kwota zarobiona na koncie: {kwotaKoncowa}");
        Console.WriteLine($"Podatek Belki: {podatekBelki}");
        Console.WriteLine($"Kwota zarobiona na koncie po opodatkowaniu: {kwotaKoncowaPoPodatku}");
    }

    static decimal ObliczKwoteZysku(decimal kwotaPoczatkowa, decimal oprocentowanie, int liczbaMiesiecy)
    {
        decimal oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
        decimal kwotaKoncowa = kwotaPoczatkowa * (decimal)Math.Pow((double)(1 + oprocentowanieMiesieczne), liczbaMiesiecy);
        return kwotaKoncowa;
    }

    static decimal ObliczPodatekBelki(decimal kwota)
    {
        decimal podatek = kwota * 0.19m; // Stawka podatku Belki wynosi 19%
        return podatek;
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wybierz liczbę z przedziału 1-20, a ja ją zgadnę!");

        int dolnyPrzedzial = 1;
        int gornyPrzedzial = 20;

        bool odgadniete = false;
        int liczbaPropozycji = 0;

        while (!odgadniete)
        {
            int propozycja = (dolnyPrzedzial + gornyPrzedzial) / 2;

            Console.WriteLine($"Czy Twoja liczba to {propozycja}? Odpowiedz: -1 (mniej), 1 (więcej) lub 0 (odgadłeś): ");
            int odpowiedz = int.Parse(Console.ReadLine());

            liczbaPropozycji++;

            switch (odpowiedz)
            {
                case -1:
                    gornyPrzedzial = propozycja - 1;
                    break;
                case 1:
                    dolnyPrzedzial = propozycja + 1;
                    break;
                case 0:
                    Console.WriteLine($"Odgadłem Twoją liczbę! Liczba prób: {liczbaPropozycji}");
                    odgadniete = true;
                    break;
                default:
                    Console.WriteLine("Niepoprawna odpowiedź. Wybierz -1, 1 lub 0.");
                    break;
            }
        }
    }
}
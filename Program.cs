using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 1 1 2 3 5 8 13\nVet du hva dette er? [J/N]");

            while (true)
            {
                string inputJN = Console.ReadLine().ToUpper();

                if (inputJN == "J")
                {
                    Console.WriteLine("\nKult!");
                    Fibo();
                    return;
                }
                else if (inputJN == "N")
                {
                    Console.WriteLine("\nDet er en del av Fibonacci-sekvensen.\nDet vil si at man begynner med 0 og 1 og neste steg er alltid\nå summere de to forrige tallene.\nNå vet du det.");
                    Fibo();
                    return;

                }
                else
                {
                    FargetTekst(ConsoleColor.Magenta, "Det var et ja/nei spørsmål :( Prøv igjen [J/N]?");
                    continue;
                }

            }


        }

        static void Fibo ()
        {
            int antallInt = 0;

            while (true)
            {
                Console.WriteLine("Hvor mange Fibonaccitall vil du se?");
                string inputAntall = Console.ReadLine();

                // Sikre at det er et tall
                if (!int.TryParse(inputAntall, out antallInt))
                {
                    // Skriv ut feilmelding
                    Console.WriteLine("Det der var ikke et tall :(");

                    // Fortsett
                    continue;
                }

                antallInt = Int32.Parse(inputAntall);

                int foerste = 0;
                int andre = 1;

                string fibSekvens = foerste.ToString() + " " + andre.ToString();

                if (antallInt < 2)
                {
                    FargetTekst(ConsoleColor.Magenta, "Må jo ha de to første, så du får ikke færre enn to stykker :D\nHer er to i hvert fall:");
                }

                for (int i = 2; i < antallInt; i++)
                {
                    andre += foerste;
                    foerste = andre - foerste;
                    fibSekvens += " " + andre.ToString();

                }

                Console.WriteLine(fibSekvens);

                // Spør om brukeren vil fortsette
                FargetTekst(ConsoleColor.Cyan, "Prøv igjen? [J/N]");

                string svar = Console.ReadLine().ToUpper();

                if (svar == "J")
                {
                    continue;
                }
                else if (svar == "N")
                {
                    return;
                }
                else
                {
                    FargetTekst(ConsoleColor.Magenta, "Det var ikke et ja, så jeg antar at det var et nei.");
                    return;
                }

            }

            

        }

        // Skriv ut farget tekst
        static void FargetTekst(ConsoleColor farge, string tekst)
        {
            // Endre farge
            Console.ForegroundColor = farge;

            // Skriv ut tekst
            Console.WriteLine(tekst);

            // Reset farge
            Console.ResetColor();
        }
    }
}
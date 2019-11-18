using System;

namespace array_aufgabe_2
{
    class Program
    {
        public static void SpieleLotto(int[] arr)
        {
            Random rnd = new Random();
            int[] ziehung = new int[6];
            int anzahl, anzahlZiehungen = 0;
            do
            {
                for (int i = 0; i < 6; i++)
                {
                    ziehung[i] = rnd.Next(1, 50);
                    for (int j = 0; j < i; j++)
                    {
                        while (ziehung[i] == ziehung[j])
                        {
                            ziehung[i] = rnd.Next(1, 50);
                        }
                    }
                }
                anzahl = 0;
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (ziehung[i] == arr[j])
                        {
                            anzahl++;
                        }
                    }
                }
                anzahlZiehungen++;

            } while (anzahl != 6);
            Console.Write("Die Lottozahlen(Angaben ohne Gewähr): ");
            foreach (int z in ziehung)
                Console.Write(" " + z);
            Console.Write("\nIhre Zahlen: ");
            foreach (int y in arr)
                Console.Write(" " + y);
            Console.WriteLine("\nNach {0} Ziehungen hättest du gewonnen.\n", anzahlZiehungen);

        }
        static void Main(string[] args)
        {
            int[] zahlen = new int[6];
            int zahl;
            bool valid = false;
            Console.WriteLine("Wilkommen bei Lotto!\n\n\nDrücken Sie eine beliebige Tase, um fortzufahren");
            Console.ReadKey();
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Geben Sie ihre {0}. Zahl ein: ", (i + 1));
                    valid = Int32.TryParse(Console.ReadLine(), out zahl);
                    if (valid != true                                               // Eingabe ungültig
                        || Array.Exists<int>(zahlen, element => element == zahl)    // Eingabe bereits enthalten
                        || zahl < 1 || zahl > 49)                                   // Eingabe keine Lottozahl
                    {
                        valid = false;
                        Console.WriteLine("Diese Eingabe ist ungültig. Versuche erneut ...\nDrücke beliebige Taste, um fortzufahren.");
                        Console.ReadKey();
                        continue;
                    }
                    else
                    {
                        zahlen[i] = zahl;
                    }
                } while (valid != true);
            }
            SpieleLotto(zahlen);
            Console.ReadLine();
        }
    }
}

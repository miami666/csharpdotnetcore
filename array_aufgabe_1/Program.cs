using System;
/*

Schreiben Sie bitte ein C#-Programm, das
a) in einer Endlosschleife den User zu Beginn jeden Durchlaufs fragt, ob er eine  ...
	(1) Übersetzung, oder
	(2) Monatsnummer wünscht

b) bei Eingabe von (1) einen deutschen Monatsnamen abfragt und die englische Übersetzung ausgibt
c) bei Eingabe von (2) einen deutschen Monatsnamen abfragt und die Monatsnummer ausgibt (Januar=1, ...)
d) bei Fehleingaben (Auswahl ungleich 1 und 2 / nicht-existenter deutscher Monatsname) eine entsprechende Fehlermeldung ausgibt

Bemerkung:
Versuchen Sie die Aufgabe bitte zunächst durch zwei 1-dimensionale String-Arrays zu lösen.
*/

namespace array_aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string monat;
            int zahl = 0;
            string[,] uebersetzung = new string[12, 2] {
                {"Januar","January"},
                {"Februar","February"},
                {"März","March"},
                {"April","April"},
                {"Mai","May"},
                {"Juni","June"},
                {"Juli","July"},
                {"August","August"},
                {"September","September"},
                {"Oktober","October"},
                {"November","November"},
                {"Dezember","December"}
            };

            do
            {
                Console.Clear();
                Console.WriteLine("(1) Übersetzung\t(2) Monatsnummer");
                int.TryParse(Console.ReadLine(), out zahl);
                if (zahl == 1)
                {


                    Console.WriteLine("Monat auf deutsch: ");
                    monat = Console.ReadLine().ToLower();
                    for (int i = 0; i < uebersetzung.GetLength(0); i++)
                    {
                        if (uebersetzung[i, 0].ToLower() == monat)
                        {
                           
                            Console.WriteLine("Monat auf Englisch: "+uebersetzung[i, 1]);
                            Console.ReadKey();
                            break;
                        }
                    }
                }
                else if(zahl==2) {
                     monat = Console.ReadLine().ToLower();
                    for(int i=0;i<uebersetzung.GetLength(0); i++) {
                        
                        if (uebersetzung[i, 0].ToLower() == monat)
                        {

                            
                            Console.WriteLine("Monatsnummer: "+Convert.ToInt32(i+1));
                            Console.ReadKey();
                            break;
                        }
                    }
                }
                else {
                
                    Console.WriteLine("keine gültige Eingabe");
                    Console.ReadKey();
                    continue;
                }
            } while (true);
        }
    }
}

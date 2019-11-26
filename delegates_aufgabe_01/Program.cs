using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
/*
 *  - Erstellen Sie in der Klasse Program den Delegate "Ausgabe", der als Parameter ein String Array erhält
 *  - Erstellen Sie die drei void Methoden Bildschirm, Datei und Datenbank für den Delegate
 *      (d.h. gleiche Parameter)
 *  - Die drei Methoden sollen jeden String im Array testweise auf der Konsole ausgeben wobei
 *      die Methoden zur Unterscheidung auch das Ziel der Ausgabe mit ausgeben sollen
 *      z.B. Console.WriteLine("Schreibe {0} in die Datenbank...", daten[i]);
 *  - Testen Sie die Methoden und den Delegate im Main, indem Sie dort ein String Array anlegen,
 *      dem Delegate die Methoden zuweisen und aufrufen.
 */


namespace delegates_aufgabe_01
{
    delegate void Del_Ausgabe(string[] s);
    class Program
    {
                static void Main(string[] args)
        {
            string[] wtf =  {"What","the","fuck"};
            Del_Ausgabe ausgabe = Bildschirm;
            
            ausgabe(wtf);

            ausgabe=Datei;

            ausgabe(wtf);

            ausgabe=Datenbank;
            ausgabe(wtf);

            
            Console.ReadKey();
        }
        static void Bildschirm(string[] arr)
        {
            foreach (string d in arr)
            {
                Console.WriteLine("Schreibe {0} auf Bildschirm", d);
            }
         
        }
        static void Datei(string[] arr)
        {
                foreach (string d in arr)
            {
                Console.WriteLine("Schreibe {0} in Datei", d);
            }
        }
        static void Datenbank(string[] arr)
        {
               foreach (string d in arr)
            {
                Console.WriteLine("Schreibe {0} in Datenbank", d);
            }
        }

    }
}

using System;
/*
Arrays: Aufgabe 1
Schreiben Sie bitte ein C#-Programm, das
 in einer Endlosschleife den User zu Beginn jeden Durchlaufs fragt, ob er eine 
Übersetzung, oder
Monatsnummer wünscht
bei Eingabe von (1) einen deutschen Monatsnamen abfragt und die englische Übersetzung ausgibt
bei Eingabe von (2) einen deutschen Monatsnamen abfragt und die Monatsnummer ausgibt (Januar=1, ...)
bei Fehleingaben (Auswahl ungleich 1 und 2 / nicht-existenter deutscher Monatsname) eine entsprechende Fehlermeldung ausgibt
Bemerkung:
Versuchen Sie die Aufgabe bitte zunächst durch zwei 1-dimensionale String-Arrays zu lösen.

*/
namespace tag06_arrays_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] de = new string[12] {"Januar","Februar","März","April","Mai","Juni","Juli","August","September","Oktober","November","Dezember"};
            string[] en = new string[12] {"January","February","March","April","May","June","July","August","September","October","November","December"};
            Console.WriteLine("[1]de->en [2]en->de");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                Console.WriteLine("de->en bitte deutschen monatsnamen eingeben: ");
                string input_de = Console.ReadLine();
                //int index1=Array.IndexOf(de,input_de);
                int index1=Array.FindIndex(de, t => t.IndexOf(input_de, StringComparison.InvariantCultureIgnoreCase) >=0);
                Console.WriteLine("Übersetzung in Englisch: ");
                Console.WriteLine(en[index1]);
                break;
                case "2":
                Console.WriteLine("en->de bitte englischen Monatsnamen eingeben: ");
                string input_en=Console.ReadLine();
                int index2=Array.IndexOf(en,input_en);
                Console.WriteLine("Übersetzung Deutsch: ");
                Console.WriteLine(de[index2]);
                break;
                
                default:
                Console.WriteLine("ungültige Auswahl");
                break;
            }
            Console.ReadKey();
        }
    }
}

using System;
/*/*
    - Führen Sie bitte zunächst einen Delegaten namens 'MeinDelegat' ein (übergabewerte: 2 Strings, Rückgabewert: bool)
    - Führen Sie bitte ferner die 4 folgenden Methoden ein:
        a) Name:            A_IstLängerAls_B
           Übergabewerte:   2 Strings A und B
           Funktion:        Ermittelt die Länge beider Strings 
           Rückgabewert:    true, FALLS A länger als B, SONST false 
        b) Name:            A_hatMehrEAls_B
           Übergabewerte:   2 Strings A und B
           Funktion:        Ermittelt die Anzahl der (großen oder kleinen) EŽs beider Strings 
           Rückgabewert:    true, FALLS A mehr EŽs (bzw. eŽs) als B hat, SONST false  
        c) Name:            Sortiere
           Übergabewerte:   String-Array und eine Delegat vom Typ MeinDelegat
           Funktion:        Sortiert das Array nach dem Bubblesort-Verfahren bzgl. des übergebenen Delegats [siehe Erläuterung(*)]
           Rückgabewert:    keiner 
        d) Name:            Ausgabe
           Übergabewerte:   String-Array
           Funktion:        Konsolenausgabe aller Felder (wählen Sie selbst ein Layout nach ihren Vorlieben :-)
           Rückgabewert:    keiner    Im Main
       Führen Sie bitte zunächst ein String-Array  'arr'  ein, gefüllt mit den folgenden drei Strings: "Beere","Autobahnpolizist","Tee"
       Lassen Sie den aktuellen Inhalt des Arrays bitte auf der Konsole ausgeben
       Führen Sie bitte ferner ein Delegat  d  vom Typ MeinDelegat ein und initialisieren dieses mit dem Verweis auf  A_IstLängerAls_B
       Rufen Sie anschließend bitte die Methode Sortiere auf (Übergabewerte arr und d)
       Lassen Sie bitte erneut den aktuellen Inhalt des Arrays auf der Konsole ausgeben
       Überschreiben Sie daraufhin bitte d mit dem Verweis auf  A_hatMehrEAls_B
       Rufen Sie daraufhin bitte erneut die Methode Sortiere auf (Übergabewerte arr und d)
       Lassen Sie bitte auch diesmal den aktuellen Inhalt des Arrays auf der Konsole ausgeben    (*)ERLÄUTERUNG:
       Beim Bubblesort wird pro Durchlauf der inneren Schleife entschieden, ob für zwei benachbarte Elemente 'A' und 'B' gilt: A>B ...
       ... A>B ist eine Frage der Betrachtung: Es kann alphabetisch gemeint sein, oder bzgl. der Wortlänge, oder der Anzahl der EŽs ...
       Genau dies kann durch den übergebenen Delegaten entschieden werden!*/
       namespace delegates_aufgabe_02
{
    delegate bool MeinDelegat(string a, string b);
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Beere", "Autobahnpolizist", "Tee" };
            int n = arr.Length;
           
                 foreach (string s  in arr)
                  {
                     Console.WriteLine(s);

                  } 
            MeinDelegat delegat = AlaengerB;
            Sortiere(arr, delegat);
            foreach (string s in arr)
            {
                Console.WriteLine(s);

            }
                       delegat=AeB;
                      Sortiere(arr,delegat);
                      foreach (string s  in arr)
                      {
                         Console.WriteLine(s);

                      } 
            Console.ReadKey();
        }
        static bool AlaengerB(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool AeB(string a, string b)
        {
 
            int eA = a.Length - a.ToUpper().Replace("e", "").Length;
            int eB = b.Length - b.ToUpper().Replace("e", "").Length;
           /*  if (eA > eB) return true;
            return false; */
            return(eA>eB)?true:false;

   
        }
        static void Sortiere(string[] s, MeinDelegat meinDelegat)
        {


            int n = s.Length;

            for (int i = 1; i < n; i++)
            {
                String temp = s[i];
               

               
                int j = i - 1;
                while (j >= 0 && temp.Length < s[j].Length)
                {
                    s[j + 1] = s[j];
                    j--;
                }
                s[j + 1] = temp;

            }
        }
       
        static void Ausgabe(string[] arr)
        {
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }
}

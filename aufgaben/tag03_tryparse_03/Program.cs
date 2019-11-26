using System;
/* TryParse: Aufgabe 3
  Schreiben Sie bitte ein C#-Programm, in dem ...
zunächst ein leerer String s eingeführt wird
eine for-Schleife gestartet wird, die 5-mal durchlaufen wird. Pro Durchlauf:
wird mit ReadKey() - also ohne Return - vom User ein Zeichen abgefragt
wird das Zeichen an den String s angehängt
nach der Schleife mit TryParse getestet wird, ob der gefüllte String in einen Integer ge-parsed werden kann
falls geparsed werden kann UND die Eingabe dem Integer 12345 entspricht erscheint auf der Konsole "Tür wird geöffnet!"
sonst: "Sie erhalten keinen Einlass!"
das Programm nach einem beliebigen Tastendruck beendet wird

  HINWEISE:
Das bei ReadKey() vom User eingetippte Zeichen erscheint auf der Konsole, das war für uns bisher nur immer "unsichtbar", da unser programm bisher immer mit ReadKey() endete.
Recherchieren Sie bitte zur Anweisung   Console.ReadKey().KeyChar um in der Lage zu sein, mit dem eingegebenen Zeichen auch arbeiten zu können.
 */

namespace tag03_tryparse_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

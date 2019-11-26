using System;
/*

CallByReference: Aufgabe 1
Schreiben Sie bitte ein C#-Programm, in dem ...
zunächst 3 Strings (vorname,nachname,vorPunktNach) eingeführt werden
nachname ist mit "Meyer" initialisiert
vorname ist zu Beginn mit "unbekannt" initialisiert
vorPunktNach ist zu Beginn NICHT initialisiert
anschließend die Funktion 'fragUndFüll' aufgerufen wird
Die Funktion erhält als Übergabewerte den Value nachname und die Referenzen vorname und vorPunktNach
Die Funktion fragt vom User den Vornamen ab
Die Usereingabe soll die Variable vorname überschreiben
Ferner soll in vorPunktNach der erste Buchstaben des Vornamens, gefolgt von einem Punkt und dem Nachnamen abgespeichert werden
zuletzt eine Kontrollausgabe alle drei Variablen auf der Konsole ausgibt

*/

namespace tag05_callbyref_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

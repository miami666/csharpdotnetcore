using System;
/*

CallByReference: Aufgabe 3
Schreiben Sie bitte die folgende Methode: (und testen Sie diese durch geeigneten Code im Main)
Name: StringZuDatum
Übergabewerte: 1 String 'datumZahl' (z.B. "01.01.2000") und eine Referenz auf einen    String 'datumText'
Funktion: a) versucht den String datumZahl in ein Objekt vom Typ DateTime zu parsen
b) falls das Parsen den Rückgabewert 'true' hat, dann wird datumText wie folgt gefüllt:
(Beispiel: bei datumZahl="01.01.2000" wird datumText mit "1.Januar 2000" gefüllt)
c) falls das Parsen den Rückgabewert 'false' hat, dann wird datumText mit 'null' gefüllt
Rückgabewert: ...... 'true', falls das Parsen (siehe oben) den Rückgabewert true hatte, sonst 'false'

HINWEIS
Die folgende Anweisung erzeugt ein Objekt vom Typ 'DateTime'
DateTime datum = new DateTime();
Die folgenden zwei Zeilen initialisieren einen String und versuchen diesen in datum zu parsen - bei Erfolg ist der Rückgabewert 'true', sonst 'false'
string s = "29.02.2000";
bool parseOk = DateTime.TryParse(s, out datum);
datum kann nun wie folgt ausgelesen werden:
int tag = datum.Day     // tag hat nun den Wert 29
int monat = datum.Month // monat hat nun den Wert 2
int jahr = datum.Year   // jahr hat nun den Wert 2000

*/

namespace tag05_callbyref_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

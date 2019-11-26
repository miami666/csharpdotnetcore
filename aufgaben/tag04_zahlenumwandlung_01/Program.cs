using System;
/* Zahlenumwandlung: Aufgabe 1
Schreiben Sie bitte ein C#-Programm, in dem innerhalb einer Endlosschleife ...
 eine ganze Zahl 'z' abgefragt wird (Eingabe dezimal - Wiederholung bis Eingabe korrekt)
eine ganze Zahl 'b' abgefragt wird (Eingabe dezimal - Wiederholung bis Eingabe korrekt)
eine Funktion aufruft, die z in einen String konvertiert (Der String soll z als Zahl zur Basis b darstellen)
Name der Funktion: 'DezInBasis'
Übergabewerte: z und b
Rückgabewert: der oben angesprochene String
der nächste Schleifendurchlauf nach Tastendruck startet

Erläuterung an 2 Beispielen:
Der Aufruf von DezInBasis(8,2) ergibt als Rückgabewert den String "1000", denn 1000 ist die binäre Darstellung von 8
Der Aufruf von DezInBasis(172,16) ergibt als Rückgabewert den String "ac", denn ac ist die hexadezimale Darstellung von 172

2 Wichtige Hinweise:
C# unterstützt bei der Syntax Convert.ToString(zahl,basis) NICHT JEDE Basis 
    => ermitteln Sie bitte die zulässigen Basen und lassen Sie die Funktion nur für zulässige Basen aufrufen
 C# unterstützt bei der Syntax Convert.ToString(zahl,basis) NICHT die Umwandlung von negativen Zahlen
    => ergänzen Sie bitte die Funktion 'DezInBasis' dahingehend, dass diese auch für negative Zahlen sinnvolle Ergebnisse liefert */


namespace tag04_zahlenumwandlung_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

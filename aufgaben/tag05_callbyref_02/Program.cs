using System;
/*
CallByReference: Aufgabe 2
AUFGABE A
Schreiben Sie bitte zunächst die folgende (CallByReference)-Methode:
Name: InputInt
Übergabewerte: 1 String s (z.B. "Geben Sie bitte eine ganze Zahl ein: ") und eine Referenz auf einen Integer x
Funktion: 1.) Es wird s auf der Konsole ausgegeben
2.) Vom User wird eine ganze Zahl abgefragt und in dem String 'eingabe' abgespeichert
3.) Der String 'eingabe' wird in einen Integer mit TryParse geparsed, dieser Integer-Wert wird in x abgespeichert
Rückgabewert: True, falls TryParse True zurückgibt, sonst False

AUFGABE B
Testen Sie bitte die obige Funktion durch folgendes Programm:
 Das Programm startet eine Endlos-Schleife, die pro Durchlauf …
eine do-while-Schleife startet, die pro Durchlauf
die Methode InputInt() aufruft
solange wiederholt wird, solange der Rückgabewert von InputInt() False ist
nach der do-while-Schleife den eingegebenen User-Wert zu der Variable 'summe' aufaddiert
die aktuelle Summe auf der Konsole ausgibt

*/

namespace tag05_callbyref_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

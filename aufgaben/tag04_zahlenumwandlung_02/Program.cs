using System;
/*
Zahlenumwandlung: Aufgabe 2
AUFGABE A
Schreiben Sie bitte zunächst die beiden folgenden Methoden (und testen Sie diese mit dem Programm aus AUFGABE B)
Methode
Funktionsname: HexInBin
Übergabewert: 1 String 's1' (Zahl in hexadezimaler Darstellung, Korrektheit wird nicht geprüft)
Funktion: s1 wird in einen String s2 übersetzt, der den selben Wert in binärer Form darstellt
Rückgabewert: s2
Methode
Funktionsname: BinInHex
Übergabewert: 1 String 's1' (Zahl in binärer Darstellung, Korrektheit wird nicht geprüft)
Funktion: s1 wird in einen String s2 übersetzt, der den selben Wert in hexadezimaler Form darstellt
Rückgabewert: s2

AUFGABE B
Schreiben Sie bitte ein C# Programm, in dem ...
in einer Endlos-Schleife pro Durchlauf …
Eine Auswahl zwischen 2 Alternativen abgefragt wird:
Alternative (1) : Hex ---> Bin
Alternative (2) : Bin ---> Hex
falls der User 1 auswählt, …
dann wird er aufgefordert eine hexadezimal dargestellte Zahl einzugeben
die Eingabe (Korrektheit wird nicht überprüft) wird als Übergabewert an HexInBin übergeben
der Rückgabewert von HexInBin wird auf der Konsole ausgegeben
das Programm wartet auf einen Tastendruck, wenn dieser geschieht, wird die Konsole gelöscht und die Schleife startet von neuem
falls der User 2 auswählt, …
dann wird er aufgefordert eine binär dargestellte Zahl einzugeben
die Eingabe (Korrektheit wird nicht überprüft) wird als Übergabewert an BinInHex übergeben
der Rückgabewert von BinInHex wird auf der Konsole ausgegeben
das Programm wartet auf einen Tastendruck, wenn dieser geschieht, wird die Konsole gelöscht und die Schleife startet von neuem
falls der User weder 1 noch 2 eingibt, wird die Konsole gelöscht und die Abfrage nach der Auswahl (1) oder (2) wird wiederholt
*/

namespace tag04_zahlenumwandlung_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

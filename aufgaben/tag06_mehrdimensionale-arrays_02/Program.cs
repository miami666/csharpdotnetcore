﻿using System;
/*
Mehrdimensionale Arrays: Aufgabe 2
Schreiben Sie bitte zunächst die beiden folgenden Methoden:
Funktionsname: FülleLottoArray
Übergabewerte: 1 Referenz auf ein Integer-Array
Funktion:      Füllt in das Array mit 6 Lottozahlen (Zahlen zwischen 1 und 49, KEINE Zahl darf mehrfach auftreten)
Rückgabewert:  Keiner
Funktionsname: ZähleTreffer
Übergabewerte: 2 Integer-Array a und b
Funktion:      Zählt die Anzahl der "Treffer" (= Anzahl der Zahlen, die in a und b gemeinsam auftreten)
Rückgabewert:  Anzahl der Treffer
    
Verwenden Sie obige Funktionen bitte in folgendem C#-Programm, in dem ...
zunächst ein Lottotipp ausgelost wird (Random oder vom Benutzer eingeben lassen) und in einem Array 'tipp' abgespeichert wird
anschließend eine do-while-Schleife startet, die pro Durchlauf
eine Lotto-Auslosung (6 Zahlen, also ohne Zusatzzahl) in ein Array 'auslosung' abspeichert
Lottotipp und (aktuelle) Auslosung auf der Konsole ausgibt
aktuelle Anzahl der Treffer (wie viele Richtige wurden erzielt?) ermittelt und auf der Konsole ausgibt
die Auslosung in einem 2-dimensionalen Array abspeichert
vor dem Start des nächsten Durchlaufs auf einen Tastendruck wartet
die Schleife endet, wenn (mindestens) 3 Treffer erreicht wurden, oder 10 Durchläufe / Auslosungen stattfanden  
nach der Schleife zur Kontrolle die Auslosungen des 2-dimensionalen Arrays auf der Konsole ausgegeben werden

*/

namespace tag06_mehrdimensionale_arrays_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

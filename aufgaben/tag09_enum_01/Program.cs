using System;

/*
Enum Aufgabe 1
Schreiben Sie bitte ein C#-Programm, in dem ...
das Enum Ihk eingeführt wird (für die Noten sehrGut=92, gut=81, ... bis ungenügend=0)
vom User in einer Schleife eine Punktzahl abgefragt wird
(die Schleife wird - ohne Fehlermeldung - wiederholt, falls Eingabe nicht zwischen 0 und 100, oder ein anderer Fehler geschah)
nach der Schleife wird der Name des entsprechenden Enum-Wertes ausgegeben
    (also sehrGut bei Eingaben zwischen 100 und 92
    gut bei Eingaben von 81 bis 91
                  … )    
2 Hinweise:
Versuchen Sie bitte den letzten Punkt mit einer foreach-Schleife zu lösen
Das ganze geschieht natürlich aus Trainingsgründen ... Problem natürlich: sehrGut statt "sehr gut"
  Man würde hier also normalerweise eher ein string-Array in Betracht ziehen

*/

namespace tag09_enum_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

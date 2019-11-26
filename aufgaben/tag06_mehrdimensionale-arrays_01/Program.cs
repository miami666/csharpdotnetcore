using System;
/*
Mehrdimensionale Arrays: Aufgabe 1
Schreiben Sie bitte ein C#-Programm, in dem
ein 2-dimensionales Array (Dimensionen 2,3) namens "lexikon" eingeführt wird
in [0,x] (für alle x=0;1 oder 2) ein Begriff initialisiert wird
in [1,x] jeweils die Erläuterung des Begriffes abgespeichert wird
in einer Endlosschleife vom User pro Durchlauf ein Begriff abgefragt wird
die passende Erläuterung ausgegeben wird, oder eine Fehlermeldung, falls der Begriff nicht vorhanden

Beispiel:
lexikon[0,0]="Auto" / lexikon[1,0]="Motorisiertes Straßen-Fahrzeug mit 4 Rädern"
lexikon[0,1]="OOP" / lexikon[1,1]="Abkürzung für 'Objektorientierte Programmierung'"
lexikon[0,2]="Süßstoff" / lexikon[1,2]="Kalorienarmer Zuckerersatz"

Hinweis:
die erste Dimension (2) zählt also die "Textarten" (Begriff oder Erläuterung)
die zweite Dimension (3) zählt die Anzahl der abgespeicherten Begriffs-Erläuterungs-Paare

*/

namespace tag06_mehrdimensionale_arrays_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

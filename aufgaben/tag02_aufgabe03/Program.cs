using System;

/* Übung Schleifen
AUFGABE A
Schreiben Sie bitte ein C#-Programm, in dem ...
in einer Schleife solange zwei Zufallszahlen vom Typ Double ausgelost werden, bis diese (auf 3 Nachkommastellen gerundet) identisch sind
nach der Schleife soll auf der Konsole erscheinen, wie viele Durchläufe benötigt wurden

HINWEIS:
Der sogenannte "Erwartungswert" wäre 1000 Versuche. Sie werden daher (auf lange Strecke) im Durchschnitt den Wert 1000 erhalten.

AUFGABE B
Ergänzen Sie den bisherigen Quellcode durch eine weitere (diesmal verschachtelte) Schleife ...
in der inneren Schleife sollen erneut wie in Aufgabe A zwei Double-Werte verglichen werden und die Anzahl der benötigten Durchläufe 'x' ermittelt werden
Die Äußere Schleife soll 10000-mal durchlaufen werden, pro Durchlauf soll …
die innere Schleife gestartet und abgearbeitet werden (insbesondere soll also ein aktuelles 'x' ermittelt werden)
der aktuelle x-Wert zu einer Gesamtsumme aufadiert werden
nach der verschachtelten Schleife soll der Durchschnittswert der benötigten Durchläufe der inneren Schleife (also Gesamtsumme/10000) auf der Konsole auf 2 Nachkommastellen gerundet ausgegeben werden

HINWEIS:
Hier sollte sich nun obige Bemerkung bestätigen und der Durchschnittswert nahe bei 1000 liegen. */


namespace tag02_aufgabe03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

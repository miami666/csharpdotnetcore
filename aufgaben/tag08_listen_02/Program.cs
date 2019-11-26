using System;
/*
Listen: Aufgabe 2
Schreiben Sie bitte zunächst die 3 folgenden Methoden:
Funktionsname: SchreibeListe
Übergabewert:  1 Referenz auf eine String-Liste 'l'
Funktion: l wird sortiert, anschließend werden alle Strings in l auf der Konsole ausgegeben
Rückgabewert:  Keiner
Funktionsname: MitLeerzeichen
Übergabewert:  1 String 's'
Funktion:      Füllt die boolsche Variable 'b' mit 'true', FALLS s (mindestens) ein Leerzeichen besitzt, SONST 'false'
Rückgabewert:  b
Funktionsname: SchonVorhanden
Übergabewert:  1 String-Liste 'l' und ein String 's'
Funktion:      Füllt die boolsche Variable 'b' mit 'true', FALLS s in l vorkommt, SONST 'false'
Rückgabewert:  b

Testen Sie die obigen Methoden bitte mit Hilfe des folgenden Programms:
Zunächst wird eine String-Liste eingeführt
Das Programm startet eine Endlos-Schleife, in der pro Durchlauf …
die Konsole gelöscht wird
vom User ein Wort abgefragt wird
falls in der Eingabe ein Leerzeichen vorkommt: entsprechende Fehlermeldung:
falls in der Eingabe KEIN Leerzeichen vorkommt, ABER die Eingabe bereits in der Liste vorkommt: entsprechende Fehlermeldung
falls WEDER eine Leerzeichen vorkommt NOCH die Eingabe bereits vorkommt, so wird die Eingabe in die Liste mit aufgenommen
alle Elemente der Liste werden auf der Konsole ausgegeben
der Schleifendurchlauf endet nach einem Tastendruck

*/
namespace tag08_listen_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

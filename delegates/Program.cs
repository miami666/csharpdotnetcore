﻿/*
    Delegate
        
    Ein Delegate ist ein Funktionszeiger-Typ, also ein Typ, für den gilt, dass Objekte von diesem Typ einen Funktionszeiger
    darstellen. Bei der Einführung dieses Typs wird festgelegt, welche Übergabewerte und welcher Rückgabewert verlangt werden.
    Einer objektvariablen von diesem Typ kann dann jede beliebige Funktion zugewiesen werden, die genau diese Über- und Rückgabewerte
    besitzt.

    Falls man einer Delegatvariablen MEHRERE solche Funktionen zuweist, so werden diese (in der Reihenfolge der Zuweisung) nacheinander
    abgearbeitet. (In diesem Fall spricht man von einem "Multicast-Delegaten")
*/
using System;


namespace delegates
{
    // Delegate stellen einen Typen dar. Deklaration ist daher an folgenden Positionen im Code erlaubt:
    // a) In einer Klasse als Member
    // b) auf Ebene der (anderen) Klassen
    // ABER NICHT innerhalb von Methoden

    // Beispiel für die Deklaration eines Delegaten-Typs
    delegate int DelegatTyp(int a, int b);
    // Syntax
    //[Zugriffsmodus] delegate RückgabeTYP NameDesDelegatTypen(Paramtereliste ...)

    
    class Program
    {
        static int summe(int x, int y)
        {
            Console.WriteLine("Die Methode summe() arbeitet gerade");
            return x + y;
        }

        static int produkt(int x, int y)
        {
            Console.WriteLine("Die Methode produkt() arbeitet gerade");
            return x * y;
        }

        static void Main(string[] args)
        {
            // Instanziierung UND Initialisierung eines Objekts vom Typ DelegateTyp:
            DelegatTyp delegat = new DelegatTyp(summe); // Name einer Funktion OHNE runde Klammern = Adresse (Pointer, Zeiger) dieser Methode
            // Aufruf der Methode auf die delegat im Moment zeigt:
            delegat(2, 3); // Reiner Aufruf läßt den Rückgabewert natürlich "verpuffen"
            Console.WriteLine();

            Console.WriteLine("Kontrolle: Rückgabewert von d(2,3)={0} (für d=summe)", delegat(2, 3));
            Console.WriteLine();

            // Überschreiben von delegat:
            delegat = produkt;
            Console.WriteLine("Kontrolle: Rückgabewert von d(2,3)={0} (für d=produkt)", delegat(2, 3));
            Console.WriteLine();

            // Überschreiben von delegat mit summe UND produkt
            delegat = summe; // Im Moment "beheimatet" delegat also ausschließlich die Methode summe
            delegat = delegat + produkt; // (bzw. delegat+=produkt)
            // delegat besitzt nun die Verweise von summe UND produkt und arbeitet beide Methoden in genau jener Reihenfolge ab, mit der diese in
            // delegat eingetragen wurden
            Console.WriteLine("Kontrolle: Rückgabewert von d(2,3)={0} (für d=summe+produkt)", delegat(2, 3));
            Console.WriteLine();
            // ACHTUNG: Beim Aufruf eines Multicast-Delegaten von zwei Methoden mit Rückgabewert wird NUR der Rückgabewert der
            //          zuletzt eingetragenen Methode ausgegeben.   

            // Delegate können auch aus einem Multicast-Delegat wieder entfernt werden:
            // (Weil immer nur der letzte Kandidat gelöscht wird, ein etwas ausführlicheres Beispiel, um dies demonstrieren zu können)
            delegat = summe;
            delegat += produkt;
            delegat += summe;
            delegat += produkt; // dies ist der letzte Eintrag von produkt und verschwindet bei "delegat-=produkt"
            delegat += summe;
            // Im Moment ist also summe+produkt+summe+produkt+summe in unserer Multicast-Varaible, wenn wir jetzt produkt entfernen,
            // wird das letzte eingetragene produkt entfernt, alle anderen bleiben erhalten
            Console.WriteLine("Kontrolle: Rückgabewert von d(2,3)={0} (für d=summe+produkt+summe+produkt+summe)", delegat(2, 3));
            Console.WriteLine();

            delegat = delegat - produkt; // (alternativ: delegat-=produkt)
            Console.WriteLine("Kontrolle: Rückgabewert von d(2,3)={0} (für d=summe+produkt+summe+produkt+summe-produkt)", delegat(2, 3));
            Console.WriteLine();

            // BEMERKUNG:
            // Man könnte nun den Eindruck gewinnen, dass ein Multicast-Delegat überflüssig ist, da ja ohnehin nur der Rückgabewert
            // der zuletzt eingetragenen Methode ausgegeben wird. Dem ist aber im Allgemeinen nicht so:
            //      Beispiele:
            //           - Methode A speichert einen Wert in Einer Datenbank ab. Methode B gibt den Wert auf der Konsole aus
            //           - Methode A aktualisiert einen Kontostand, Methode B informiert den Kunden
            //           - ...

            Console.ReadKey();
        }
    }
}
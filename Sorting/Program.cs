using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sort
{
    static void Main(string[] args)
    {
        //Variablen deklarieren
        var rand = new Random();
        int[] array = new int[100];
        int zaehler = 0;
        int temp = 0; //Hilfsvariable zum Tauschen

        //Generieren der Zufallswerte im Array
        for(zaehler=0;zaehler<100;zaehler++)
            {
                array[zaehler]=rand.Next(1,999);   //Hier Zufallsrange eintragen
            }
        
        //Suchen der Min und Max Werter
        int min = array.Min();
        int max = array.Max();

        //Ausgabe von Min und Max
        Console.WriteLine("Minimal Value: " + min);
        Console.WriteLine("Maximal Value: " + max);

        //Sortieren...
        for (int j = 0; j < array.Length - 1; j++) { //Wiederholung des Vorgangs bis alle Elemente sortiert sind
            for (int i = 0; i < array.Length - 1; i++) { //Platzieren des größten Elementes nach rechts
                if (array[i] > array[i + 1]) { //Wenn des Aktuelle Elements kleiner als das nächste ist...
                    temp = array[i + 1]; //...dann speichern des kleineren in Hilfsvariable
                    array[i + 1] = array[i]; //größere Element an "höhere" Position speichern
                    array[i] = temp; //kleinere Element aus Hilfsvariable in "niedrigere" Stelle schreiben
                }
            }
        }

        //Ausgabe des Sortierten Arrays
        for (int i = 0; i < array.Length; i++) {
            Console.Write(array[i]);
            Console.Write(" | ");
        }
        Console.WriteLine("");
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicationConsole.Basics
{
    class Collections
    {
        // Arraylisten
        ArrayList myArrayList = new ArrayList();        // undefinierte Anzahl
        ArrayList myArrayList2 = new ArrayList(100);    // definierte Anzahl

        public void ArrayListOperations()
        {
            var sum = 0.0;
            myArrayList.Add(100);
            myArrayList.Add("Test");
            myArrayList.Add(12.3);

            myArrayList.RemoveAt(2);        // Position als Parameter angeben
            myArrayList.Remove("Test");     // entfernt das erste Element mit "Test"

            foreach (var elem in myArrayList)
            {
                if (elem is int)
                {
                    sum += Convert.ToDouble(elem);
                }
                else if (elem is double)
                {
                    sum += (double)elem;
                }
            }
            Console.WriteLine($"Ausgabe {sum}");
        }
    }
}

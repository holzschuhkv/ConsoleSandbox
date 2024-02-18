using System;
using System.Collections;

namespace TestApplicationConsole.Basics
{
    class ArrayOperationen
    {
        // 3D Array
        int[,,] MatrixTest3D = new int[,,] //Ebene, Zeile, Spalte
        {
            {//Ebene 1
                {1, 3, 4 },// Zeile 1
                {4, 2, 5 }
            },
            {//Ebene 2
                {2, 1, 2 },
                {4, 9, 2 }
            },
            {//Ebene 3
                {3, 2, 1},
                {8, 2, 1}
            }
        };

        // 2D Array mit Initialisierung
        int[,] MatrixTest2D = new int[,] // Zeile, Spalte
            {
                {1, 2, 3}, //Zeile 0
                {4, 5, 6}  //Zeile 1
            };

        // Verzweigte Arrays
        #region
        int[][] jaggedArray = new int[3][];
        public void InitilisizeJaggedArray()
        {
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[] { 3, 1, 53, 2 };
            jaggedArray[2] = new int[2];
        }

        int[][] jaggedArray2 = new int[][]
            {
                new int[] {3, 2, 5 }, //Zeile 1
                new int[] {3, 1, 2 }  //Zeile 2
            };
        #endregion

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

            foreach(var elem in myArrayList)
            {
                if(elem is int)
                {
                    sum += Convert.ToDouble(elem);
                }
                else if(elem is double)
                {
                    sum += (double)elem;
                }
            }
            Console.WriteLine($"Ausgabe {sum}");
        }

        public void TestFunction(int[] ArrayInput)
        {
            foreach(var elem in ArrayInput)
            {
                Console.WriteLine(elem + Environment.NewLine);
            }
        }
    }
}

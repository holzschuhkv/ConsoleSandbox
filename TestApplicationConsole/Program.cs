using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestApplicationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> asdf = new Dictionary<int, int>();
            //TestÄnderung

            Console.ReadKey();
        }
    }
}


#region
/*
// Datenkapselung mit Eigenschaftsmethoden
// Filtern von set und get Accessor
DatenkapselungProperties DatenKaspelung = new DatenkapselungProperties();
DatenKaspelung.TestValue = -1; // poperty mit if anweisung
            DatenKaspelung.TestValueMitStartwert = 4; // auto-property

            Console.WriteLine($"Auto-Property Startwert {DatenKaspelung.TestValueMitStartwert}"); // ausgabe auto-property mit Startwert
            //

            /// <summary>
            /// Klassenoperationen mit Vererben und Datenkapselung 
            /// </summary>
            MainClass BasisKlasse = new MainClass();
MainClass BasisKlasse2 = new MainClass("TestArgument", 123);
DerivedClass vererbteKlasse = new DerivedClass();

vererbteKlasse.Input = $"Zugriff auf BASIS Klasse inclusive Ausgabe Datenkapselungen.{BasisKlasse}";

            vererbteKlasse.Input = "Property Input gesetzt"; //set
            Console.WriteLine(Environment.NewLine + vererbteKlasse.Input); //get


            Console.WriteLine(Environment.NewLine + BasisKlasse.VirtualTestMethode()); //virtual
            Console.WriteLine(vererbteKlasse.VirtualTestMethode()); //override


            DerivedClass vererbteKlasse2 = new DerivedClass("VERERBTE KLASSE | Erweiterter-Konstruktoraufruf", 123);


/// <summary>
/// Polymorphie
/// </summary>

PolyBaseClass PolyKlasse = new PolyBaseClass(12);

Console.WriteLine(Environment.NewLine + "PolyKlasse : " + PolyKlasse.Param1);

            DerivedPolyClass dPolyKlasse = new DerivedPolyClass(1, 2);



/// <summary>
/// MethodsForTesting
/// </summary>

var testingMethods = new MethodsForTesting();
var output = testingMethods.InputStringToUpperCase("test");


/// <summary>
/// ENDE
/// </summary>
*/
#endregion
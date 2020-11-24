using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicationConsole
{
    class DatenkapselungProperties
    {
        private int _TestValue;
        private int _TestValueWithLambda;

        // Selbsterstellte Property mit IF-Filterung
        public int TestValue
        {
            get // Werte zurückgeben
            {
                return _TestValue;
            }
            set // Werte setzen
            {
                if (value < 0)
                {
                    Console.WriteLine($"Input-Wert {value} ist fehlerhaft! (value > 0)");
                }
                else
                {
                    Console.WriteLine($"Input-Wert {value} ist in Ordnung! (value < 0)");
                    _TestValue = value;
                }
            }
        }

        /// <summary>
        /// Auto-Property mit Initializer = 100
        /// kann nur bei automatisch generierten Properties erstellt werden
        /// </summary>
        public int TestValueMitStartwert { get; set; } = 100;

        // Properties die nur ein get oder set enthalten haben eine bestimmte Funktionsweise
        // ONLY get => readonly field 
        // (difference to readonly => readonly elements are declared during class creation or constructor calls, not changable later)
        //
        // ONLY set => for dependency injection instead of using a constructor for the injection you are using properties

        internal string TestStringProperty { get; set; }

        public int TestValueWithLambda
        {
            get => _TestValueWithLambda;
            set => _TestValueWithLambda = value;
        }
    }
}

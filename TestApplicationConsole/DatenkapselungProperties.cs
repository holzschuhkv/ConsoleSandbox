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

        // Selbsterstellte Property mit Filterung
        public int TestValue
        {
            get
            {
                return _TestValue;
            }
            set
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
    }
}

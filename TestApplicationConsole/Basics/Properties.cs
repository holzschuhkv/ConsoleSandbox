using System;

namespace TestApplicationConsole.Basics
{
    class DatenkapselungProperties
    {
        // bei der Angabe eines Zugriffsmodifizierers müssen beide Accessoren angegeben werden
        // nur ein Accessor darf einen unterschiedlichen Modifizierer zur Property haben
        // Modifizierer muss einschrenkender sein als der der Property
        public int PropertyWithDiffAccess
        {
            get;
            private set;
        }


        private int _TestValue;
        // Selbsterstellte Property mit IF-Filterung
        public int TestValue
        {
            get
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
        /// Auto-Property mit Initializer(Startwert) = 100
        /// </summary>
        public int TestValueMitStartwert { get; set; } = 100;

        // Properties können auch nur einen Accessor (get, set) aufweisen
        // ONLY get => readonly field (nur Lesezugriff)
        // (difference to readonly => readonly elements are declared during class creation or constructor calls, not changable later)
        //
        // ONLY set => for dependency injection instead of using a constructor for the injection you are using properties
        internal string TestStringProperty { get; } //readonly


        /// <summary>
        /// Property implementation with lambda expression
        /// </summary>
        private int _TestValueWithLambda;
        public int TestValueWithLambda
        {
            get => _TestValueWithLambda;
            set => _TestValueWithLambda = value;
        }

        /// <summary>
        /// satic properties for classes
        /// </summary>
        private static int _staticTestProperty;
        public static int StaticTestProperty
        {
            get { return _staticTestProperty; }
        }
    }
}

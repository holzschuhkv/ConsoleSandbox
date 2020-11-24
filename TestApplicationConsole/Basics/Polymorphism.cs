using System;

namespace TestApplicationConsole
{
    class PolyBaseClass
    {
        public int Param1 { get; } // Schreibgeschützt

        public PolyBaseClass() {}
        public PolyBaseClass(int param1)
        {
            this.Param1 = param1;
            Console.WriteLine("\n\nAufruf\n");
        }
    }

    class DerivedPolyClass : PolyBaseClass
    {
        // This constructor calls PolyBaseClass.PolyBaseClass(int i)
        public DerivedPolyClass(int param2, int param1) : base(param1)
        {
            Console.WriteLine("\n\ndPolyKlasse" + param1 + "\n" + param2);
        }
    }
}

namespace ConsoleSandbox.Basics
{
    /// <summary>
    /// Abstract classes can not be instanced!
    /// </summary>
    abstract class PolyBaseClass
    {
        public int Param1 { get; } // Schreibgeschützt

        public PolyBaseClass()
        {
            Console.WriteLine("PolyBaseClass - DefaultConstructor call");
        }

        public PolyBaseClass(int param1)
        {
            Console.WriteLine($"PolyBaseClass(int param1): param1 = {param1}");
        }

        public PolyBaseClass(int param2, int param1) : this(param1)
        {
            Param1 = param1;
            Console.WriteLine($"PolyBaseClass(int param2, int param1): param2 = {param2}");
        }

        public abstract void AbstractMethod(); // abstract method

        public virtual void VirtualMethod()
        {
            Console.WriteLine("PolyBaseClass - VirtualMethod");
        }
    }

    class DerivedPolyClass : PolyBaseClass
    {
        // This constructor calls the constructor from the base class: PolyBaseClass.PolyBaseClass(int i)
        public DerivedPolyClass(int param3, int param2, int param1) : base(param2, param1)
        {
            Console.WriteLine($"DerivedPolyClass: param3 = {param3}");
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("DerivedPolyClass - AbstractMethod");
        }
    }

    class DerivedPolyClass2 : PolyBaseClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("DerivedPolyClass2 - AbstractMethod");
        }

        public override void VirtualMethod()
        {
            base.VirtualMethod();
        }
    }
}

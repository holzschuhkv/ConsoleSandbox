using System;

namespace TestApplicationConsole.Basics
{
    /// <summary>
    /// Classes are per default -> internal
    /// </summary>
    class MainClass
    {
        private string _Input;
        public string testInput = "BASIS KLASSE | testInput Ausgabe";
        public int id = 0;

        public MainClass()
        {
            Console.WriteLine($"\nBASIS KLASSE | Standard-Konstruktor - ID {id}");
        }
        
        public MainClass(string valString = "default", int id = 123)
        {
            Console.WriteLine($"BASIS KLASSE | Überladener Standard-Konstruktor mit Argument: {id}");
            this.id = id;
        }

        // Datenkapselung
        public string Input 
        {
            get
            {
                return this._Input;
            }
            set
            {
                this._Input = value;
            }
        }

        /// <summary>
        /// virtual wird meistens nur bei der Basis Klasse verwendet da von derived Klassen
        /// überschrieben wird. Beste Beispiel Formen -> Kreis -> Rechteck (die Flächen Methode
        /// in Formen muss virtual sein)
        /// </summary>
        /// <returns></returns>
        public virtual string VirtualTestMethode()
        {
            return "BASIS KLASSE | VirtualTestMethod";
        }
    }

    class DerivedClass : MainClass
    {
        public DerivedClass()
        {
            Console.WriteLine("\nVERERBTE KLASSE | Standard-Konstruktor");
        }

        public DerivedClass(string testInput, int id)
        {
            Console.WriteLine($"{testInput} - ID {id}");
            this.testInput = testInput;
            this.id = id;
        }

        public override string VirtualTestMethode()
        {
            return "VERERBTE KLASSE | VirtualTestMethod";
        }
    }

    static class StaticTestClass
    {
        static public void testMethodFromStaticTestClass()
        {
            Console.WriteLine("StaticTestClass - via 'using static class'");
        }
    }

    partial class Circle
    {
        public Circle()
        {
            //default constructor
            Console.WriteLine("returning contructor of first partial class of circle");
        }

        public void circlePartOneMethod()
        {
            Console.WriteLine("circlePartOneMethod");
        }
    }

    partial class Circle
    {
        public void circlePartTowMethod() 
        {
            Console.WriteLine("circlePartOneMethod");
        }
    }
}

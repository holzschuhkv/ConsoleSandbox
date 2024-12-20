using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicationConsole.Basics
{

    internal class Events
    {
        public delegate void DemoEventHandler();

        public event DemoEventHandler MethodEvent;

        public void MainEntry()
        {
            DemoEventHandler test = TestMethod;

            test();
        }

        public static void EventCompleted()
        {
            Console.WriteLine("Test");
        }


        private void TestMethod()
        {
            MethodEvent();
        }
    }


    internal class Program
    {
        // Delegate with parameter
        internal delegate int OperationDelegate(int Input);

        static void Main()
        {
            // Example with instance method
            var testClass = new TestClass();
            var delegateWithInstance = new OperationDelegate(testClass.Addition); // Adding instance method
            OperationDelegate delegateWithInstance2 = testClass.Addition;

            delegateWithInstance(0);

            // Example with static method
            OperationDelegate delegateWithStatic = TestClass.Substraction; // Adding static method
            delegateWithStatic(0);
        }
    }

    internal class TestClass
    {
        internal int Addition(int inVar)
        {
            Console.WriteLine("Addition");
            return 1;
        }

        internal static int Substraction(int inVar)
        {
            Console.WriteLine("Substraction");
            return -1;
        }
    }
}

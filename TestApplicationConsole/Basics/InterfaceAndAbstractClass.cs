using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicationConsole.Basics
{
    /// <summary>
    /// All methods in an interface are declared as public. No private methods can be implemented.
    /// If you want to implement protected methods, you have to use an abstract class as template.
    /// </summary>
    interface IBasicInterface
    {
        int TestMethod();

        string StringTestMethod();

        void VoidTestMethod();
    }

    /// <summary>
    /// Gets basic information from the interface IBasicInterface. It additional declares an protected abstract method.
    /// </summary>
    abstract class AbstractTestClass : IBasicInterface
    {
        public abstract int TestMethod();
        public abstract string StringTestMethod();
        public abstract void VoidTestMethod();

        protected abstract void TestClass();
    }


    class InterfaceClass : AbstractTestClass
    {
        public override int TestMethod() 
        {
            return 1;
        }

        public override string StringTestMethod()
        {
            return "test";
        }

        public override void VoidTestMethod()
        {

        }

        protected override void TestClass()
        {

        }
    }
}

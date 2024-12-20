using Ausgabe = System.Console;
using namespaceTwo = TestApplicationConsole.Basics.NamespaceTwo;
using static TestApplicationConsole.Basics.StaticTestClass;
using static System.Console;

namespace TestApplicationConsole.Basics
{
    class NamespaceOne
    {
        internal void TestMethod()
        {
            // access via the :: operator. only used by Aliases. 
            //
            // because of this: using namespaceTwo = TestApplicationConsole.Basics.NamespaceTwo;
            var testnamespacetwo = new namespaceTwo::NamespaceTwoClass();

            testnamespacetwo.TestMethodNamespaceTwo();

            // with the keyword global you are able to access the global namespace
            global::System.Console.WriteLine("test via global");

            // :: operator
            // ist notwendig um auf den globalen Namespace zuzugreifen
            // wird benutzt um bei Verwendung von Aliases-Namespaces der Eindeutigkeitshalber zu verwenden. Access zu Aliases


            // call this static method from an static class.
            // only possible because of using static in the head. no qualifier is needed
            testMethodFromStaticTestClass();
            WriteLine("new C# Feature 'using static'");
        }
    }
}

namespace TestApplicationConsole.Basics.NamespaceTwo
{
    class NamespaceTwoClass
    {
        internal void TestMethodNamespaceTwo()
        {
            Ausgabe.WriteLine("TestApplicationConsole.Basics - NamespaceTwo");
        }
    }
}

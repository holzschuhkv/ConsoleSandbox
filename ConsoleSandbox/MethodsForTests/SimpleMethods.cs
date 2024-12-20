namespace ConsoleSandbox.MethodsForTests
{
    // work in progress


    /// <summary>
    /// In this file are methods for nunit testing
    /// </summary>
    public class SimpleMethods
    {
        string value1 = "StringValue";

        public SimpleMethods()
        {

        }

        public string SimpleStringReturn(string Input)
        {
            if (Input.Contains("Admin"))
            {
                return "isAdmin";
            }
            else if (!Input.Contains("User"))
            {
                return "isUser";
            }
            else
                return "IsGuest";
        }

        public int BasicCalculation(int value1, int value2)
        {
            return value1 + value2;
        }

        public string InputStringToUpperCase(string inputString)
        {
            return "UPPER_CASE" + inputString.ToUpper() + "UPPER_CASE";
        }

        public IEnumerable<int> EnumerableIntegerOutput(int limit)
        {
            for (var x = 0; x < limit; x++)
            {
                yield return x;
            }
        }

        public TestObjectClass ReturnTypeTestObjectClass()
        {
            return new TestObjectClass();
        }
    }

    public class TestObjectClass { }
}

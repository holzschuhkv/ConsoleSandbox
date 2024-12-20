using System.Collections;

namespace ConsoleSandbox.Advanced
{
    class Collections
    {
        // work in progress

        ArrayList myArrayList = new ArrayList();      
        ArrayList myArrayList2 = new ArrayList(100);  

        public void ArrayListOperations()
        {
            var sum = 0.0;
            myArrayList.Add(100);
            myArrayList.Add("Test");
            myArrayList.Add(12.3);

            myArrayList.RemoveAt(2);        
            myArrayList.Remove("Test");    

            foreach (var elem in myArrayList)
            {
                if (elem is int)
                {
                    sum += Convert.ToDouble(elem);
                }
                else if (elem is double)
                {
                    sum += (double)elem;
                }
            }
            Console.WriteLine($"Ausgabe {sum}");
        }
    }
}

using System.Collections;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intList = new int[3];
            intList[0] = 1;
            intList[1] = 5;

            for (int i = 0; i < intList.Length; i++)
            {
                Console.WriteLine(i);
            }

            ArrayList strArray = new ArrayList();
            strArray.Add("Hello");
            strArray.Add("Hi");
            strArray.Add("What's up!");

            foreach (string greeting in strArray)
            {
                Console.WriteLine(greeting);
            }
        }
    }
}

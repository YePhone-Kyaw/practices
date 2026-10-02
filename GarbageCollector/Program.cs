namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                Customer customer = new Customer();
                customer.name = "Zayden";

            }
            Console.ReadLine();
        }
    }

    class Customer
    {
        public string name = "";
    }
}

///* ***** Notes *****
///* GC is background thread which keeps running and keeps checking that if an object is out of scope or not.
///* If the object does not have any reference on the stack, it tries to clean the kmemory
///* Can be checked in the Debug -> Performance Profiler..
///* Check it in the Release mode.

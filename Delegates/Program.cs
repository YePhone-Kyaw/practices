namespace Delegates
{
    class Program
    {
        static void IamListener(int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            MyClass x = new MyClass();
            x.streamObj = IamListener;
            Task t = new Task(x.Task);
            t.Start();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }

    class MyClass
    {
        public delegate void Stream(int i); // Declaration of the delegate
        public Stream streamObj; // Create an instance

        public void Task()
        {
            for (int i = 0; i < 10000; i++)
            {
                Thread.Sleep(1000);
                streamObj(i);
            }
        }
    }
}

// Delegates

// Point of Delegates is to listen something with the asyncronus 
// more related to event (callback)
// i want to listen something which is asyncronus event and data
// Multicast delegates, Action, Predicate, Func, Event

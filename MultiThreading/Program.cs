namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creat Thread
            // Thread t1 = new Thread(new ThreadStart(Function1));

            // Task t1 = new Task(Function1); // this does not have Thread Affinity

            // Thread t2 = new Thread(new ThreadStart(Function2));

            // Task t2 = new Task(Function2);

            // t1.Start(); // Start executing Function1 parallely

            // t2.Start(); // Start executing Function2 parallely

            Function1(); // This is for async-await thing testing function call
            Function2(); // This is for async-await thing testing function call

            Console.WriteLine("Hello World!");



            // If we just call the function like below, Function1 will run until it finishes to begin Function2.
            // If we wanna use the parallel running, we need to use Thread [the above code]
            // Function1();
            // Function2();
        }

        static async void Function1()
        {
            for (int i = 0; i < 10000; i++)
            {
                // Thread.Sleep(1000);
                await Task.Delay(1000);

                Console.WriteLine($"Function 1 result: {i}");
            }
        }
        static async void Function2()
        {
            for (int i = 0; i < 10000; i++)
            {
                // Thread.Sleep(1000);
                await Task.Delay(1000);

                Console.WriteLine($"Function 2 result: {i}");
            }
        }
    }
}


///*
/// Task Parallel Library (TPL) => Try to use Task instead of Thread for the Multithreading or parallel execution cuase Task automatically knows and decides to run the Tasks in sequence.
/// 
/// Suggest to use Task not Thread
/// 
/// Task is buit on top of Threading too
/// 
/// Running things parallely will need extra resources (like CPU)
/// 
/// Thread Affinity - Thread has Thread Affinity while Task doesn't have
///
/// -------------------------------------------------------------------
/// We can use Async-Await for running the tasks (but not parallely, asyncronusly like alternatively) 
/// This will reduce the unnecessary resources usage like Tread or Task


// Concurrency (Related to Async/Await) vs Parallelism (Related to Thread and Task)

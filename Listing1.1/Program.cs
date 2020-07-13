using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing1._1
{
    /// <summary>
    /// A dimenstration for the method Invoke of the Parallel class.
    /// The Task.Parallel class can be found in the System.Threading.Tasks namespace.
    /// The Parallel.Invoke method accepts a number of Action delegates and creates a Task for each of them.
    /// An Action delegate is an encapsulation of a method that accepts no parameters and does not return a result.
    /// It can be replaced with a lamba expression, as shown in Listing 1-1, in which two tasks are created.
    /// </summary>
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("Task 1 Starting...");
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 Ending...");
        }

        static void Task2()
        {
            Console.WriteLine("Task 2 Starting...");
            Thread.Sleep(1000);
            Console.WriteLine("Task 2 Ending...");
        }
        /// <summary>
        /// The Parallel.Invoke method can start a large number of tasks at once.
        /// You have no control over the order in which the tasks are started or which processor they are assigned to.
        /// The Parallel.Invoke method returns when all of the tasks have completed.
        /// You can see the output from the program here.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Parallel.Invoke(() => Task1(), () => Task2());
            //Parallel.Invoke(Task1, Task2);
            Console.WriteLine("Finished Processing. Press a key to end");
            Console.ReadKey();
            
        }
    }
}

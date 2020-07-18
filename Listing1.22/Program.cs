using System;
using System.Threading;

namespace Listing1._22_thread_lambda_parameters
{
    /// <summary>
    /// Another way to pass data into a thread is to specify the behavior of the thread as a lambda expression that accepts a parameter.
    /// The parameter to the lambda expression is the data to be passed into the thread.
    /// </summary>
    class Program
    {
        static void WorkOnData(object data)
        {
            Console.WriteLine("Working on: {0}", data);
            Thread.Sleep(1000);
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread((param) => WorkOnData(param));
            thread.Start(99);

            Console.WriteLine("Press a key to end.");
            Console.ReadKey();
        }
    }
}

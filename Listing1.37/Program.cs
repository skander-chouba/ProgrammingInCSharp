using System;
using System.Collections.Concurrent;

namespace Listing1._37_Concurrent_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
            queue.Enqueue("Rob");
            queue.Enqueue("Miles");
            if (queue.TryPeek(out string str))
            {
                Console.WriteLine("Peek: {0}", str);
            }
            if (queue.TryDequeue(out str))
            {
                Console.WriteLine($"Dequeue: {str}");
            }

            Console.WriteLine("Finished Process, press any key to continue...");
            Console.ReadKey();
        }
    }
}

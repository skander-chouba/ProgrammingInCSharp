using System;
using System.Collections.Concurrent;

namespace Listing1._38_Concurrent_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<string> stack = new ConcurrentStack<string>();
            stack.Push("Rob");
            stack.Push("Miles");
            if (stack.TryPeek(out string str))
            {
                Console.WriteLine($"Peek: {str}");
            }
            if (stack.TryPop(out str))
            {
                Console.WriteLine($"Pop: {str}");
            }

            Console.WriteLine("Finished Process, press any key to continue...");
            Console.ReadKey();
        }
    }
}

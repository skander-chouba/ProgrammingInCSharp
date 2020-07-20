using System;
using System.Collections.Concurrent;

namespace Listing1._39_Concurrent_Bag
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<string> bag = new ConcurrentBag<string>();
            bag.Add("Rob");
            bag.Add("Miles");
            bag.Add("Mostfa");
            bag.Add("Fred");
            bag.Add("Olga");
            bag.Add("Tamas");
            bag.Add("Gunter");
            bag.Add("Sascha");
            bag.Add("Oliver");
            bag.Add("Fabian");
            if (bag.TryPeek(out string str))
            {
                Console.WriteLine($"Peek: {str}");
            }
            if (bag.TryTake(out string str2))
            {
                Console.WriteLine($"Take: {str2}");
            }

            Console.WriteLine("Finished Process, press any key to continue...");
            Console.ReadKey();
        }
    }
}

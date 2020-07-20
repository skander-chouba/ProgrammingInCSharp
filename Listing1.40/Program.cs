using System;
using System.Collections.Concurrent;

namespace Listing1._40_Concurrent_Dictionary
{
    /// <summary>
    /// A dictionary provides a data store indexed by a key. A ConcurrentDictionary can be used by multiple concurrent tasks.
    /// Actions on the dictionary are performed in an atomic manner.
    /// In other words, an update action on an item in the dictionary cannot be interrupted by an action from another task.
    /// A ConcurrentDictionary provides some additional methods that are required when a dictionary is shared between multiple tasks.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<string, int> ages = new ConcurrentDictionary<string, int>();
            if (ages.TryAdd("Skander", 25))
            {
                Console.WriteLine("Skander added successfully");
            }
            Console.WriteLine($"Skander's age: {ages["Skander"]}");

            //Set Skander's age to 26 if it's 25
            if (ages.TryUpdate("Skander", 26, 25))
            {
                Console.WriteLine("Age updated successfully");
            }
            Console.WriteLine($"Skander's new age: {ages["Skander"]}");

            // Increment Skander's age atomically using factory method
            Console.WriteLine($"Skander's age updated to: {ages.AddOrUpdate("Skander", 1, (name, age) => age += 1)}");
            Console.WriteLine($"Mosta's age updated to: {ages.AddOrUpdate("Mostfa", 1, (name, age) => age += 1)}");

            Console.WriteLine("Skander's new age: {0}", ages["Skander"]);
            Console.WriteLine("Mostfa's new age: {0}", ages["Mostfa"]);

            Console.WriteLine("Finished Process, press any key to continue...");
            Console.ReadKey();
        }
    }
}

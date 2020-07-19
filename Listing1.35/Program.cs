using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace LISTING_1_35_Using_BlockingCollection
{
    /// <summary>
    /// The BlockingCollection<T> class is designed to be used in situations where you have some tasks producing data and other tasks consuming data.
    /// It provides a thread safe means of adding and removing items to a data store.
    /// It is called a blocking collection because a Take action will block a task if there are no items to be taken.
    /// A developer can set an upper limit for the size of the collection. Attempts to Add items to a full collection are also blocked.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Blocking collection that can hold 5 items
            BlockingCollection<int> data = new BlockingCollection<int>(5);

            Task.Run(() =>
            {
                //attempt to add 10 items to the collection - blocks after 5.
                for (int i = 0; i < 11; i++)
                {
                    data.Add(i);
                    Console.WriteLine($"data {i} added successfully");
                }
                //indicate we have no more to add
                data.CompleteAdding();
            });

            Console.ReadKey();
            Console.WriteLine("Reading collection");

            Task.Run(() =>
            {
                while (!data.IsCompleted)
                {
                    try
                    {
                        int v = data.Take();
                        Console.WriteLine($"data {v} taken successfully");
                    }
                    catch (InvalidOperationException) { }
                }
            });

            Console.WriteLine("Finished Process, press any key to continue...");
            Console.ReadKey();
        }
    }
}

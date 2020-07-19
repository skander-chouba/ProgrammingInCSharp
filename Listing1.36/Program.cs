using System;
using System.Collections.Concurrent;

namespace Listing1._36
{
    /// <summary>
    /// The BlockingCollection class can act as a wrapper around other concurrent collection classes, including ConcurrentQueue, ConcurrentStack, and ConcurrentBag.
    /// The collection class to be used is given as the first parameter of the BlockingCollection constructor.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> data = new BlockingCollection<int>(new ConcurrentQueue<int>(), 5);
        }
    }
}

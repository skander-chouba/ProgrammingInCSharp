﻿using System;
using System.Threading;

namespace LISTING_1_28_Thread_pool
{
    class Program
    {
        static void DoWork(object state)
        {
            Console.WriteLine("Doing work: {0}", state);
            Thread.Sleep(500);
            Console.WriteLine("Work finished: {0}", state);
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                int stateNumber = i;
                ThreadPool.QueueUserWorkItem(state => DoWork(stateNumber));
            };
            Console.ReadKey();

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}

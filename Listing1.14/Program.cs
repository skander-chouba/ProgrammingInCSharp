﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace LISTING_1_14_Task_waitall
{
    /// <summary>
    /// The Task.Waitall method can be used to pause a program until a number of tasks have completed.
    /// This listing also illustrates an additional issue with the use of loop control variables when they are passed into lambda expressions.
    /// The loop counter is copied into a local variable called taskNum in the loop that creates each task.
    /// If the variable i was used directly in the lambda expression, all of the tasks would have number 10, which is the value of the limit of the loop.s
    /// </summary>
    class Program
    {
         /// <summary>
         /// Another use for Task.Waitall is to provide a place where a program can catch any exceptions that may be thrown by tasks.
         /// Note that, as with exceptions generated by PLINQ queries, the exceptions are aggregated.
         /// </summary>
        public static void DoWork(int i)
        {
            Console.WriteLine("Task {0} starting", i);
            Thread.Sleep(2000);
            Console.WriteLine("Task {0} finished", i);
        }
        /// <summary>
        /// You can use Task.WaitAny to make a program pause until any one of a number of concurrent tasks completes.
        /// If you think of each task as a horse in a race; WaitAll will pause until all the horses have finished running, 
        /// whereas WaitAny will pause until the first horse has finished running.
        /// In the same way that horses still run after the winner has finished, some tasks will continue to run after a WaitAny call has returned.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Task[] tasks = new Task[10];
            for (int i = 0; i < 10; i++)
            {
                int taskNum = i;//make a local copy of the loop count
                                //correct task number is passed into 
                                //Lambda expression
                tasks[i] = Task.Run(() => DoWork(taskNum));
            }
            Task.WaitAll(tasks);

            Console.WriteLine("Finished Process, press any key to continue...");
            Console.ReadKey();
        }
    }
}
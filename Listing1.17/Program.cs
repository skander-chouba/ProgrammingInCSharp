using System;
using System.Threading;
using System.Threading.Tasks;

namespace LISTING_1_17_Attached_child_tasks
{
    /// <summary>
    /// Code running inside a parent Task can create other tasks, but these “child” tasks will execute independently of the parent in which they were created.
    /// Such tasks are called detached child tasks or detached nested tasks. 
    /// A parent task can create child tasks with a task creation option that specifies that the child task is attached to the parent.
    /// The parent class will not complete until all of the attached child tasks have completed.
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// The tasks are created by calling the StartNew method on the default Task Factory provided by the Task class.
        /// This overload of the StartNew method accepts three parameters:
        /// the lambda expression giving the behavior of the task,
        /// a state object that is passed into the task when it is started,
        /// and a TaskCreationOption value that requests that the new task should be a child task.
        /// </summary>
        /// <param name="state"></param>
        public static void DoChild(object state)
        {
            Console.WriteLine("Child {0} starting", state);
            Thread.Sleep(2000);
            Console.WriteLine("Child {0} finished", state);
        }
        /// <summary>
        /// You can create a task without any attached child tasks by specifying the TaskCreationOptions.DenyChildAttach option when you create the task.
        /// Children of such a task will always be created as detached child tasks. 
        /// Note that tasks created using the Task.Run method have the TaskCreationOptions.DenyChildAttach option set, and therefore can’t have attached child tasks.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var parent = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Parent Starts");
                for (int i = 0; i < 10; i++)
                {
                    int taskNo = i;
                    Task.Factory.StartNew((x) => DoChild(x), //lambda expression
                        taskNo, //state object
                        TaskCreationOptions.AttachedToParent
                    ); 
                }
            });
            parent.Wait(); //will wait for all attached children
            Console.WriteLine("Finished Processing, press any key to continue...");
            Console.ReadKey();
        }
    }
}

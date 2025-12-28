using System;
using System.Threading;
using System.Threading.Tasks;

namespace Day10.AsyncMultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            //Thread Example
            ThreadExample();

            //Task Example
            TaskExample();

            //Async Await Example
            AsncAwaitExample().Wait();

            //DeadLock Example - Do not run
           // DeadLockExample();

            //Lock Example
            LockExample();

            Console.WriteLine("Main Thread Ended");
            Console.ReadLine();

        }
        static void ThreadExample()
        {
            Thread thread = new Thread(() =>
            {
                Console.WriteLine("Thread Started");
                Thread.Sleep(1000);
                Console.WriteLine("Thread Finished");
            }
            );
            thread.Start();
            thread.Join();
        }
        static void TaskExample()
        {
            Task task = Task.Run(()=>
            {
                Console.WriteLine("Task Started");
                Thread.Sleep(1000);
                Console.WriteLine("Task Finished");
            });
            task.Wait();
        }
        static async Task AsncAwaitExample()
        {
            Console.WriteLine("Async Method Started");
            await Task.Delay(1000);
            Console.WriteLine("Async Method Completed");
        }
        static void DeadLockExample() 
        {
            var result = GetDataAsync().Result;
            Console.WriteLine(result);

        }
        static async Task<string> GetDataAsync()
        {
            await Task.Delay(1000);
            return "Data Loaded";
        }
        static int counter = 0;
        static readonly object lockobj=new object();
        static void LockExample() 
        {
            Task t1 = Task.Run(IncrementCounter);
            Task t2 = Task.Run(IncrementCounter);
            Task.WaitAll(t1,t2);
            Console.WriteLine($"Final Counter Value: {counter}");
        }
        static void IncrementCounter()
        {
            for (int i=0;i<1000;i++)
            {
                lock (lockobj)
                {
                    counter++;
                }
            }
        }
    }
}
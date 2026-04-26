using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class Program
    {
        // Modern way: async Main method
        static async Task Main(string[] args)
        {
            Console.WriteLine("Synchronous Execution");
            SyncMethod();

            Console.WriteLine("\nAsynchronous Execution");
            await AsyncMethod();   // No need for .Wait()

            Console.WriteLine("\nProgram Finished");
        }

        // 1. Synchronous Method
        static void SyncMethod()
        {
            Console.WriteLine("Task 1 Started");
            Thread.Sleep(3000); // Blocking call
            Console.WriteLine("Task 1 Completed");

            Console.WriteLine("Task 2 Started");
            Thread.Sleep(2000); // Blocking call
            Console.WriteLine("Task 2 Completed");
        }

        // 2. Asynchronous Method
        static async Task AsyncMethod()
        {
            Task t1 = LongTask1();
            Task t2 = LongTask2();

            await t1;
            await t2;
        }

        // 3. Async Task 1
        static async Task LongTask1()
        {
            Console.WriteLine("Async Task 1 Started");
            await Task.Delay(3000); // Non-blocking delay
            Console.WriteLine("Async Task 1 Completed");
        }

        // 4. Async Task 2
        static async Task LongTask2()
        {
            Console.WriteLine("Async Task 2 Started");
            await Task.Delay(2000); // Non-blocking delay
            Console.WriteLine("Async Task 2 Completed");
        }
    }
}
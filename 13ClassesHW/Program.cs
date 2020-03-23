using System;
using System.Threading;
namespace _13ClassesHW
{
    class Program
    {
        static int deep;
        static void Recursion()
        {
            Console.WriteLine("{0} say \"Hello\"", Thread.CurrentThread.Name);
            Thread.Sleep(1);
            Thread thread2 = new Thread(Recursion);
            deep++;
            thread2.Name = "Thread " + deep;
            thread2.Start();
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(Recursion) { Name = "Thread " + deep };
            thread.Start();
        }
    }
}

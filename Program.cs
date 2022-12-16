using System;
using System.Net;
using System.Text;
using System.Threading;

namespace threads
{
    class thread_func
    {
        Thread thread;

        public thread_func(string name, int num)
        {

            thread = new Thread(this.func);
            thread.Name = name;
            thread.Start(num);
        }

        void func(object num)
        {
            for (int i = 0; i < (int)num; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " выводит " + i);
                Thread.Sleep(0);
            }
            Console.WriteLine(Thread.CurrentThread.Name + " завершился");
        }
    }

    class Program
    {
        static void Main()
        {
            thread_func t1 = new thread_func("Thread 1", 6);
            thread_func t2 = new thread_func("Thread 2", 3);
            thread_func t3 = new thread_func("Thread 3", 2);

            Console.ReadKey();
        }
    }
}
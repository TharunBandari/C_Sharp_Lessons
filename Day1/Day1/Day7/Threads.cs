/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Day7
{
    internal class Threads
    {
        internal static void DemoB()
        {
            throw new NotImplementedException();
        }s

        internal class ServiceA
        {
            int x = 0;
            public void DoTaskA()
            {
                Monitor.Enter(this);
                Thread t1 = Thread.CurrentThread;
                int id = t1.ManagedThreadId;
                Console.WriteLine("Inside doTaskA");
                Console.WriteLine("\t Thread ID: " + id);
                //int x = 0;              //Local Variable


                for (int icount = 0; icount <= 5; icount++)
                {
                    x += icount;
                    Console.WriteLine("\tID=" + id + ":X=" + x + "icount=" + icount);
                    Thread.Sleep(1000);
                }

            }
            static void DemoA()
            {
                Thread t = Thread.CurrentThread;
                int id = t.ManagedThreadId;
                Console.WriteLine("Main Th ID" + id);
                ServiceA a1 = new ServiceA();
                a1.DoTaskA();
            }
            //Multiple Threads
            public static void DemoB()
            {
                Thread t = Thread.CurrentThread;
                int id = t.ManagedThreadId;
                Console.WriteLine("MainTh ID" + id);
                ServiceA a1 = new ServiceA();
                Thread t1 = new Thread(a1.DoTaskA);       //Delegate
                t1.Start();
                a1.DoTaskA();
                Console.WriteLine("-------End of DemoB-----");
            }



        }
    }
}
*/
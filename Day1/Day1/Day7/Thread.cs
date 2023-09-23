/*using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Day7
{
    internal class Thread
    {
        *//*Thread is an independent path of executable code waiting for CPU time 
         Thread are the basic unit to which an operating system aalocates processor timw
        More than one thread can be executing code inside a process
        Operating system use processes to logically separate different application
        
        Each Thread Maintains:
        >Exception Handler
        >A Scheduling priority and 
        >a set of strcture the system uses to save the thread context until it is scheduled
         Processes and Components*/

        /*public static void DemoCurrentTH()
        {
            Thread t1 = Thread.CurrentThread();
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadID=" + id);
            Console.WriteLine("IsAline=" + t1.IsAlive);
            Console.WriteLine("Priority=" + t1.Priority);
            Console.WriteLine("ThreadState=" + t1.ThreadState);
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine( DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("fr-FR");
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("de-DE");
            Console.WriteLine("CurrentCulture" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }
    }
    *//*
        class ServiceA
        {
            public static void DoTaskA()
            {
                Thread t1 = Thread.CurrentThread;
                int id = t1.ManagedThread;
                Console.WriteLine("Inside DoTaskA");
                Console.WriteLine("\t Thread ID:" + id);
                int x = 0;
                for (int icount = 0; icount <= 5; icount++)
                {
                    x += icount;
                    Console.WriteLine("\tID=" + id + ": X=" + x + " icount" + icount);
                    Thread.sleep(1000);
                    object value = Thread.sleep(1000);

                    x += icount;
                    Console.WriteLine()
                        Thread.slepp(1000);
                    onject valur = Thread.sleep(1000)
                }
            }

            public static void DemoB()
            {
                Thread t = Thread 
                int id = t.ManagedThreadId
                    Varibale are not thread safe thread lock locking method 
                        finally will unlock and terminated 
            }
        }
    }
}
*/
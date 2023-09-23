/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

*//*
>Pointer to the Method is Called Pointer
>Data Type looks like Method 
>Strongly typed Functional Pointer are called Delegates
>Delegate are Data Type 
>There are Two Types of Delegate 
>All Events Are Multi Cast Delegate
>Events are trigger to delegate 
>Signals are multi delegates
>2 object work done without any signals are know as Indicator 
*//*

namespace ProjectOne.Day6._2
{
    public delegate void MethodhandlerA();

    public delegate int MethodhandlerB(int x, int y);
    internal class Delegate
    {
        public class pointer
        {
            public void Dotask()
            {
                Console.WriteLine("I am in Doing Task");
            }
            public int Add(int x, int y)
            {
                return x + y;
            }
            public int Multiply(int x, int y)
            {
                return x * y;
            }
            public double Divide(double x, double y)
            {
                return x / y;
            }
            public string GetMode()
            {
                return "X500";
            }
        }

        public class DelegatesDemo
        { 

            public static void TestOne()
            {
                pointer pointer = new pointer();
                MethodhandlerA methodhandlerA = *//*new MethodhandlerA*//*pointer.Dotask;
                MethodhandlerB methodhandlerB = *//*new MethodhandlerB*//*pointer.Add;
                MethodhandlerB methodhandlerTwo = *//*new MethodhandlerB*//*pointer.Multiply;

                methodhandlerA();
                int addResult = methodhandlerB(100, 50);
                Console.WriteLine(addResult);
                int multiplyResult = methodhandlerTwo(20, 5);
                Console.WriteLine(multiplyResult);
            }

            public static void TestTwo()
            {
                pointer pointer = new pointer();
                MethodhandlerB methodhandlerB = pointer.Add;
                methodhandlerB += pointer.Multiply;
                methodhandlerB(100, 50);
            }
        }
    }

    
}
*/
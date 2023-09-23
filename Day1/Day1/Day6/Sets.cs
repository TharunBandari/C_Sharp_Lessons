/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

//Sorting Done Based on the Key
//

namespace ProjectOne.Day6
{
   //out key word is Write Only not to Read 
   //In Read only Parameter
   //In out parameter for both Write and Read 
   //Param work with single Data Type

   

    
    internal class Method
    {
        *//*public static void OutParameterMethod(int v1, out int v2)
        {
            v1 = v1 + 100;
            v2 = v1 * 5;
            Console.WriteLine(v2 + " " + v1);
        }
        public static void TestOurParameter()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("Before M2==> x={0},y={1}",x,y);
            OutParameterMethod(x, out y);
            Console.WriteLine("After M2==> x={0}, y={1}",x,y);
        }*/

        /*public static void OptionalParameters(int v1 = 123, int v2 = 456)//optional
        {
            Console.WriteLine($"\tM3==> v1={v1},v2={v2}");
            v1 = v1 + 100;
            v2 = v2 * 2000;
            Console.WriteLine($"\tM3==> v1={v1},v2={v2}");
        }
        public static void TestOptionalParameter()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine($"x={x},y={y}");
            OptionalParameters();
            OptionalParameters(x, y);
            OptionalParameters(v2: x, v1: y);//Using Named Arguments
        }*//*

        //params - variable length argument
        public static void AddIntParameters(params int[] arguments)
        {
            int add = 0;
            Console.WriteLine("Param Length " + arguments.Length);
            foreach (int argu in arguments)
            {
                add += argu;
            }
            Console.WriteLine(add);
        }
        static void TestAddIntParams()
        {
            AddIntParameters(1);
            AddIntParameters(1, 2, 3, 4, 5);
        }
    }
}
*/
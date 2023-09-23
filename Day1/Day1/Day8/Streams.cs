/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Day8
{
    internal class Streams
    {
        public static void TestOne()
        {
            char ch;
            Console.WriteLine("Press a key followed by Enter:");
            int x = Console.Read(); //Read is used to read one charater //ReadLine is used o read whole sentence 
            ch = (char)x;//TextReader is a character String and it is an a Abstract class //Abstact class that consist of 
            Console.WriteLine("\n" + x + "Your key is:" + ch);
        }

        public static void TestTwo()
        {
            char ch = ' ';
            Console.WriteLine("Press a key q to exit:");
            while (ch != 'q')
            {
                ch = (char)Console.Read();
                Console.WriteLine("Your Key is:" + ch);
            }
        }

        public static void TestThree()
        {
            Console.Out.WriteLine("Enter a sentence");
            string? str = Console.ReadLine();
            Console.Out.WriteLine(" " + str);
        }

        public static void TestNullableTypes()
        {
            int? x = 0;
            x = null;
            if (x.HasValue)
            {
                Console.WriteLine(x.Value) ;
            }
            else
                Console.WriteLine(x.GetValueOrDefault());
        }
    }
}
*/
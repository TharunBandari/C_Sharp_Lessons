using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace ProjectOne.Day1
{
    internal class Statements
    {
        public static void TestOne()
        {
            Console.WriteLine("Enter Your AGE");
            String ageAsString = Console.ReadLine();
            if (IsNumeric(ageAsString))
            {
                return;
            }
            int age = int.Parse(ageAsString);
            if(age<18)
            {
                Console.WriteLine("Sorry! YOU CAN DRIVE");
            }
            else
            {
                Console.WriteLine("YES, YOU CAN DRIVE");
            }


        }
        public static bool IsNumeric(String pValue)
        {
            bool result = false;
            if(pValue == null)
            {
                Console.WriteLine("Invalid String!! Value Is Null....");
                return false;
            }
            char[] data = pValue.ToCharArray();
            int length = data.Length;
            for(int i=0; i<length; i++)
            {
                char c1 = data[i];
                int ascii = (int)c1;
                if (ascii < 48 || ascii > 57)
                {
                    Console.WriteLine("Value is not Number!!");
                    result = false;
                }
            }
        }
            
    }
}*/
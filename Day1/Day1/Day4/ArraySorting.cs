/*using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectOne.Day4
{
    internal class ArraySorting
    {
        static void Main(string[] args)
        {
            int[] data = { 45, 23, 76, 98, 2, 5, 20, 53, 12, 83, 8, 42 };

            // a. Find the total of the numbers in the array without using any in-built function
            int total = CalculateTotal(data);
            Console.WriteLine("Total: " + total);

            // b. Sort the numbers in ascending order
            SortArrayAscending(data);
            Console.WriteLine("Sorted Array: " + string.Join(", ", data));

            // c. Increase the size of the array
            int newSize = data.Length + 5;
            data = ResizeArray(data, newSize);
            Console.WriteLine("Resized Array: " + string.Join(", ", data));
        }

    }
}*/
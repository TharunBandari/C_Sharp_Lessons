/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjectOne.Day2
{
    internal class Box
    {
        public static int height;
        public int width;

    }

    public static int height;
    public int width; 
    public interface GetHeight() { ReturnTypeEncoder height; }
    internal class TestBox 
    {
        public static void TestOne()

        {
            Box.height = 100;
            Box.width = 200;
            //STATIC MEMBERS OF THE CLASS CAN BE ACCCESS WITHOUT AN OBJECT REFERENCE 
            Box firstBox = new Box();
            Box secondBox = new Box();
            firstBox.width = 1234;
            secondBox.wdith = 5678;
            Console.WriteLine($"First Box {firstBox.width}, {firstBox.GetHeight()}");
            Console.WriteLine($"Second Box {secondBox.width}, {secondBox.GetHeight()}");
            Console.WriteLine(Box.type);
            Box height = 5555;
            Console.WriteLine($"First Box= { firstBox.width}, { firstBox.GetHeight()}");
            Console.WriteLine($"second Box= {secondBox.width}, {secondBox.GetHeight()}r");
        }
    }
}*/
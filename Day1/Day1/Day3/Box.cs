/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Day3
{
    internal class Box
    {
        public int Height;
        public int Length;
        public int Width;



        public Box(int x)
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }
        public override string ToString()
        {
            return $"Height:{Height},Length:{Length},Width:{Width}";
        }
    }
    internal class WoodenBox : Box {
        public int Area;
        public WoodenBox():base(1)
        {
            Console.WriteLine("Wooden BOX Constructor");
        }
        public WoodenBox(int x):base(x)
        {
            Console.WriteLine("Wooden BOX Constructor");
        }
        public WoodenBox(int x , int y):base(x)
        {
            Console.WriteLine("Wooden BOX Constructor");
        }

        public void Move()
        {
            Console.WriteLine("Wooden Box Shifted");
        }
        public override string ToString()
        {
            return "TOM AND JERRY";
        }
    }
    internal class BoxTester
    {
        public static void TestOne()
        {
            Box box = new Box(4);
            box.Height = 10;
            box.Width = 5;
            box.Length = 28;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
            //box.Area = 100;
            //box.Move();
        }
        public static void TestTwo()
        {
            WoodenBox box = new WoodenBox();
            box.Height = 100;
            box.Width = 50;
            box.Length = 280;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
            //box.Area = 100;
            //box.Move();
        }
        public static void TestThree()
        {
            Box box = new WoodenBox();
            box.Height = 100;
            box.Width = 50;
            box.Length = 280;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
            //box.Area = 100;
            //box.Move();

        }
    }
}
*/
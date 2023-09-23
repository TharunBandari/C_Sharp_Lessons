/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Day4
{
    public enum City {  Chennai, Banglore, Hyderabad, Pune}

    public enum Designation { Manager, Admin, Developer}
    internal class Employee
    {
        public readonly int EId;
        public String EName = String.Empty;
        public City ECity; //public String Ecity
        public Designation JobTitle = String.Empty;
        //Working with Enum
        //Enum collection of constants
        //Readonly never change the Original
        public Employee(int v1) { EId = v1; }

        public override String ToString()
        {
            String output = String.Empty;
            output = $"Details of a employee are: ID={EId} Name={EName} {ECity} {JobTitle}";
            return output;
        }

        class TestEmployee
        {
            public static void TestOne()
            {
                Employee e1 = new Employee(566);
                //typeof represents meta date
                //Version number for ENUM Contents
                e1.EName = "Tharun";
                e1.ECity = City.Banglore;
                e1.JobTitle = Designation.Developer;
                String output = e1.ToString();
                Console.WriteLine(output);
            }

            public static void TestMovieRating()
            {
                Type t1 = typeof(MovieRating);
                String[] enumName = Enum.GetNames(t1);
                String name = String.Empty;

                    //Array are fixes Sized Array can have one or more objects 
    
            }
        }
    }

}*/
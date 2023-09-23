/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Day4
{
    internal class DateDemo
    {
        public static void FirstMethod()
        {
            Console.WriteLine(DateTime.Now);

            DateTime d1 = new DateTime(2000, 12, 19);
        }

        public static void SecondMethod()
        {
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            int year = d1.Year;
            Console.WriteLine("Year OF Dob " + year);
            int month = d1.Month;
            Console.WriteLine("Month OF Dob " + month);
            int day = d1.Day;
            Console.WriteLine("Day OF Dob " + day);
            DateTime d2 = d1.AddMonths(10);
            Console.WriteLine("AddMonths(10) " + d2.ToShortDateString());
            DateTime d3 = d1.AddDays(5);
            Console.WriteLine("AddDays(5) " + d3.ToShortDateString());
            DateTime d4 = d1.AddYears(58);
            Console.WriteLine("AddYears(58) " + d4.ToShortDateString());
            DateTime d5 = d1.AddYears(-5);
            Console.WriteLine("AddYears(-5) " + d5.ToShortDateString());
        }

        public static void FindAgeOfaPerson()
        {
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String Strdob = String.Empty;
            try
            {
                Console.ReadLine();
                DateTime d1 = DateTime.Parse(Strdob);
                DateTime d2 = DateTime.Now;
                TimeSpan ts = d2.Subtract(d1);
                TimeSpan age = new DateTime(ts.Ticks);
                Console.WriteLine("Age in Date" + age.ToShortDateString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void AgeOfPerson()
        {
            Console.Write("Enter birth year: ");
            int birthYear = int.Parse(Console.ReadLine());

            Console.Write("Enter birth month: ");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.Write("Enter birth day: ");
            int birthDay = int.Parse(Console.ReadLine());

            int age = CalculateAge(birthYear, birthMonth, birthDay);

            Console.WriteLine("Age: " + age);
        }

        static int CalculateAge(int birthYear, int birthMonth, int birthDay)
        //Timespan
        {
            DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
            DateTime currentDate = DateTime.Now;

            int age = currentDate.Year - birthDate.Year;

            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }

            return age;


        }

    }
}
*/
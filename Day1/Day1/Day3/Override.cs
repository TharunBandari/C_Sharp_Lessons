using ProjectOne.Day2;
using ProjectOne.Day3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Day3
{
    internal class Override
    {
        public String Name { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;
        public int Id { get; set; } //Long have to use if more than 7 digits 
        public override string ToString()
        {
        return $"NAME:{Name} {LastName}" +
            $"ID:{this.Id}"; //int we have to enter this to print the int
        }
    }
    
    internal class TestPracticalOverride
    {
        public static void TestVarun()
        {
            Override Vikram = new Override(); //proper name is to provide to  Static name
            Vikram.LastName = "Bandari"; //Last Name not to provide any allocation it allows the "{}"
            Vikram.Id = 2;
            String value = Vikram.ToString(); // Last To Lines is to execute the entire program 
            Console.WriteLine(value);
        }
    }
}

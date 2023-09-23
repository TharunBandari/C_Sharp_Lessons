using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Day2
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public int PostalCode { get; set; }
        public string Country { get; set; } = string.Empty;
        public long Phone { get; set; }

        public override string ToString()
        {
            return $"Id:{this.Id},Name:{Title} {FirstName} {LastName}," +
                $"Address:{Address}, City:{City}, State:{Region},\n" +
                $"Phone:{Phone}, Country:{Country}, Zip:{PostalCode}";
        }

        //String.Empty is used to remove null
    }
    internal class TestPerson
    {
        public static void TestTharun()
        {
            Person firstPerson = new Person();
            firstPerson.Id = 1;
            firstPerson.FirstName = "Tharun";
            firstPerson.LastName = "Bandari";
            firstPerson.Address = "HYDERABAD";
            firstPerson.City = "HYDERABAD";
            firstPerson.Country = "INDIA";
            firstPerson.Phone = 8330933023;
            firstPerson.PostalCode = 345678;
            firstPerson.Region = "Telangana";
            firstPerson.Title = "Mr";
            string value = firstPerson.ToString();
            Console.WriteLine(value);
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjectOne.Day5
{
    internal class FirstWeekExam
    {
        public static void UpperCase()
        {
            String firstString = "Tom and Jerry are Good Friends";
            String StringInUpper = firstString.ToUpper();
            Console.WriteLine("firstString:" + firstString);
            Console.WriteLine("StringInUpper" + StringInUpper);
        }
        public static void Count()
        {
            String s1 = "Tom and Jerry are good friends";
            String[] words = s1.Split(' ');
            Console.WriteLine("Word Count " + words.Count());
            foreach (var item in words)
            {
                Console.Write(item);
            }
        }
        public static void Main()
        {
            string s1 = "He was at the 24 floor of the building. He saw 42 pots of flowers there. He stop to check if the pots are watered.";
            char[] charArray = s1.ToCharArray();
            Array.Reverse(charArray);
            string s2 = new string(charArray);
            char[] ch1 = s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }


            //Console.WriteLine(reversedString);
        }

        public static void QuestionThree()
        {
            String strFriends = "Tom and Jerry are good friends";
            String strPart = strFriends.Substring(10, 5);
            Console.WriteLine(strFriends);
            Console.WriteLine(strPart);
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a name: ");
            string inputName = Console.ReadLine();

            if (IsValidName(inputName))
            {
                Console.WriteLine("Name is valid.");
            }
            else
            {
                Console.WriteLine("Name is invalid.");
            }
        }

        static bool IsValidName(string name)
        {
            // Check for minimum length of 8 characters
            if (name.Length < 8)
            {
                return false;
            }

            // Check if the name contains only alphabets using a regular expression
            return Regex.IsMatch(name, "^[a-zA-Z]+$");
        }

    }
}




*Interfaces
* IEnumerable
* IEnumerator
* ICollection
* IList
* ArrayList
* > Implements the IList inerface using array whose sizw is dynamically increased as rquires
* Quese
* > Reperents a first-in.first-out collection of object
         * Stack
         * >Repersents a simple last in first out(LIFO) non generic collection of Object
         * HashTable
         * >Repersents a collection of key/value pairs that are organized based on the hash code of the key
         * SortedList
         * >Repersents a colleciton of Key/Value pair that are sorted by the keys and are accessible by key by index.
         * 
         * Iterator - 
         * >IEnumerable 
         * >IEnumerator */
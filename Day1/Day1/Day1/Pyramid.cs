/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Day1
{
    internal class Pyramid
    {
        static void Main(String[] args)
        {
            int n = 10, m, k;
            for (int i = 1; i <= n; i++)
            {
                for (m = 1; m <= (n - i); m++)
                    Console.Write(" ");
                for (k = (i - 1); k >= 1; k--)
                    Console.Write(k);
                for (k = 2; k <= (i - 1); k++)
                    Console.Write(k);
                Console.WriteLine();
            }
        }
    }
}
*/
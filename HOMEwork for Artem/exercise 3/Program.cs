using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            if ((a[0] == a[3]) && (a[1] == a[2]))
            {
                Console.WriteLine($"{a} - полиндром");
            }
            else
            {
                Console.WriteLine($"{a} - not a полиндром");
            }
            Console.Read();
        }
    }
}

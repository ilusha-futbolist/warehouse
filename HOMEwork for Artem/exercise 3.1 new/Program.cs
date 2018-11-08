using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3._1_new
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int n = a.Length/2;
            int m = a.Length;
            bool k = true;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == a[m - 1 - i])
                {
                    k = true;

                }
                else
                {
                    k = false;
                    break;
                }
            }
            if (k)
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

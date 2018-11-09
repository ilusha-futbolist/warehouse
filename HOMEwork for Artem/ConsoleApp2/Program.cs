using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = double.Parse(Console.ReadLine());
            double b;
            b = double.Parse(Console.ReadLine());
            double c;
            c = double.Parse(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;
            double x1 = 0;
            double x2 = 0;
            if (D >= 0)
            {
                x1 = (-b + Math.Pow(D, 0.5)) / (2 * a);
                x2 = (-b - Math.Pow(D, 0.5)) / (2 * a);
                if (x1 == x2)
                {
                    Console.WriteLine($"один единственный корень {x1}");
                }
                else
                {
                    Console.WriteLine($"x1= {x1}   x2= {x2}");
                }
            }
            else
            {
                Console.WriteLine($"нет корней!!!!!!!!!!");
            }
            Console.Read();
        }

    }
}

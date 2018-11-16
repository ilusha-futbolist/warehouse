using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_lox_46
{
    class Program
    {
        static int f(int x)
        {
            int a = x;
            int b = 0;
            while (a != 0)
            {

                b = a % 10 + b * 10;
                a = a / 10;
            }
            return b;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int answer = f(a);
            Console.WriteLine(answer);








            Console.WriteLine("Artem is a MASTER");
            Console.Read();
        }
    }
}

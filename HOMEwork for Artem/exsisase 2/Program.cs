using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exsisase_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b = 1;
            Console.WriteLine("Введите число");
            a = Console.Read();

            for (int i = a; i > 1; i--)
                b = b * i;
            Console.WriteLine("Факториал  = " + b);


            Console.ReadLine();
        }
    }
}

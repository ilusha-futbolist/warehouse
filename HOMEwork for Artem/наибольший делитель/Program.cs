using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace наибольший_делитель
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int n = 2;
            int b = a / 2;
            while (a % n != 0)
            {
                n++;
                b = a / n;
                
            }
            Console.WriteLine(b);
            Console.Read();
        }
    }
}

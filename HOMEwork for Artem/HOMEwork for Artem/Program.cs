using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEwork_for_Artem
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {

                Console.WriteLine($"{i} в квадрате {Math.Pow(i, 2)}");
            }
            Console.WriteLine(UInt16.MaxValue);
            Console.ReadLine();

        }
    }
}

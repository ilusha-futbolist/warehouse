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
            Console.WriteLine();
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} в квадрате {1}", a, Math.Pow(a, 2));
            Console.ReadLine();
        }
    }
}

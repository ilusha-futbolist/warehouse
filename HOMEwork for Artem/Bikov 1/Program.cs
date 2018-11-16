using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bikov_1
{
    class Program
    {
        static bool f(int x, int y)
        {
            if ((x % y == 0) || (y % x == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool answer = f(a, b);
            Console.WriteLine(answer);










            Console.WriteLine("Artem is a MASTER");
            Console.Read();
        }
    }
}

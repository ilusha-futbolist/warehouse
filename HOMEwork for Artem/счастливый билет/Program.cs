using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace счастливый_билет
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int n = a.Length / 2;
            int m = a.Length;
            int q = 0;
            int w = 0;
            if (m % 2 == 0)
            {
                Console.WriteLine("четное кол-во символов");
                Console.WriteLine("1ая половина");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(a[i]);
                    q = q + a[i];
                }
                Console.WriteLine($"q = {q}");
                Console.WriteLine("2ая половина");
                for (int i = n ; i < m; i++)
                {
                    Console.WriteLine(a[i]);
                    w = w + a[i];
                }
                Console.WriteLine($"w = {w}");
                if (w == q)
                {
                    Console.WriteLine("счастливый билет");
                }
                else
                {
                    Console.WriteLine("несчастливый билет");
                }
            }
            else
            {
                Console.WriteLine("нечетное кол-во символов");
                Console.WriteLine("1ая половина");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(a[i]);
                    q = q + a[i];
                }
                Console.WriteLine($"q = {q}");
                Console.WriteLine("2ая половина ");
                for (int i = (n + 1); i < m; i++)
                {
                    Console.WriteLine(a[i]);
                    w = w + a[i];
                }
                Console.WriteLine($"w = {w}");
                if (w == q)
                {
                    Console.WriteLine("счастливый билет");
                }
                else
                {
                    Console.WriteLine("несчастливый билет");
                }
            }
            int s = 0x255;
            int s2 = 0b100;

            int n1 = 0x10;
            int n2 = 0b10;
            int n3 = 10;

            Console.WriteLine(s+s2);
            Console.WriteLine(n1 + n2 + n3);
            Console.Read();
        }
    }
}

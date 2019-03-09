using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int r=0;
            for (int i = -5; i < 6; i++, r+=2)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (j >= Math.Abs(-i) && j <= Math.Abs(-i)+Math.Abs(r))
                        Console.Write("*");
                    else
                        Console.Write(" ");

                    if (r % 10 == 0)
                        r = r * -1;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

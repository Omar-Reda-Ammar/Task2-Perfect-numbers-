using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2__Perfect_Numbers_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end, x, y;
            Console.Write("Enter start number : ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter end number : ");
            end = int.Parse(Console.ReadLine());
            for(x = start; x < end; x++)
            {
                long total = 0;
                for (y = 1; y <x; y++)
                {
                    if (x % y == 0)
                        total = total + y;
                }
                if (total == x)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}

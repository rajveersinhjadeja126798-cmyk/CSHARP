using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro13
{
    internal class Program
    {
        static void Main()
        {
            a = new int[10];

            Console.WriteLine("enter 10 value");

            int i;
            for(i = 0; i<10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (i = a.length - 1; i > 0; i--)
            {
                Console.WriteLine(a[i]);
            }

        }
    }
}

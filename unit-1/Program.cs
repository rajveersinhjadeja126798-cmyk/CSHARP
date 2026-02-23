using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value of a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of B");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            int d = a - b;
            int e = b * c;
            int f = a / d;

            Console.WriteLine("sum" + c);
            Console.WriteLine("sub" + d);
            Console.WriteLine("mul" + e);
            Console.WriteLine("div" + f);



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_5
{
    internal class Program
    {
        static void Main()
        {
            float pi = 3.14f;
            Console.WriteLine("enter circle area");
            float r = float.Parse(Console.ReadLine());

            float a = pi * r * r;
            
            Console.WriteLine("area of circle" + a);
          
        }
    }
}

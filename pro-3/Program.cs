using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(" simple intrest ");
            Console.WriteLine(" enter principle value ");
            float p =  int.Parse(Console.ReadLine());

            Console.WriteLine(" enter a rate value ");
            float r =  int.Parse(Console.ReadLine());

            Console.WriteLine(" enter year value ");
            float n = int.Parse(Console.ReadLine());

            double s = p * r * n / 100;

            Console.WriteLine(" simple intrest " + s);
        }
    }
}

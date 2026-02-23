using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_4
{
    internal class Program
    {
        static void Main()
        {
            {
                Console.WriteLine(" compound intrest ");

                Console.WriteLine(" enter principle value ");
                float p = int.Parse(Console.ReadLine());

                Console.WriteLine(" enter a rate value ");
                float r = int.Parse(Console.ReadLine());

                Console.WriteLine(" enter year value ");
                float n = int.Parse(Console.ReadLine());

                float s = p * r * n / 100;
                float total = s + p;
                float c = total * r / 100;
                float com = c + total;



                Console.WriteLine(" simple " + s);
                Console.WriteLine(" total " + total);
                Console.WriteLine(" compound " + c);
                Console.WriteLine(" compound intrest " + com);
            }
        }
    }
}

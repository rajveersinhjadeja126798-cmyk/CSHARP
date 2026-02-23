using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program14
{
    internal class Program
    {
        static void Main()
        {
            String name;

            Console.WriteLine("enter name");
            name = Console.ReadLine();

            string revaname = " ";
            int i;
            for (i = name.Length - 1; i >= 0; i--)
            {

                revaname += name[i];
            
            }
            if (name == revaname)
            {
                Console.WriteLine("palidron");
            }
            else
            {
                Console.WriteLine(("not palidron");
                
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UNIT_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ractangle r = new ractangle();
            r.getdata();
            r.calculate();
            r.display();

            circle circle = new circle();
            circle.getdata();
            circle.calculate(); 
            circle.display();   
        }
    }
}

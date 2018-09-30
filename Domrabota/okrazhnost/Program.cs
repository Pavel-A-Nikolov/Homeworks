using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okrazhnost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius - r:");
            double r = double.Parse(Console.ReadLine());
            Console.Write("The Area=pi*r^2=3,14*r*r=");
            Console.WriteLine(3.14 * r * r);
            Console.Write("The Curcumference=pi*2*r=6,28*r=");
            Console.WriteLine(r * 6.28);
        }
    }
}

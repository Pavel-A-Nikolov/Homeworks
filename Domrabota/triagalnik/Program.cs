using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triagalnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first side - a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the other side - b:");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third side - c:");
            double c = double.Parse(Console.ReadLine());
            Console.Write("The perimeter - P=a+b+c=");
            Console.WriteLine(a + h + c);
            Console.WriteLine("Now enter only one side - x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("And the coresponding height - h:");
            double g = double.Parse(Console.ReadLine());
            Console.Write("The face - S=0,5*x*h=");
            Console.WriteLine(0.5 * x * g);
        }
    }
}

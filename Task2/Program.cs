using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            string input = Console.ReadLine();
            double r = double.Parse(input);

            double perimeter = 2 * Math.PI * r;

            double area = Math.PI * r * r;
            Console.WriteLine("{0:F2}", perimeter);
            Console.WriteLine("{0:F2}", area);
        }
    }
}

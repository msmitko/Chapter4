using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            string input = Console.ReadLine();
            double a = double.Parse(input);

            input = Console.ReadLine();
            double b = double.Parse(input);

            input = Console.ReadLine();
            double c = double.Parse(input);

            double D = b * b - 4 * a * c;

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2.0 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2.0 * a);

                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            else if (D == 0)
            {
                double x1 = -b / (2.0 * a);

                Console.WriteLine(x1);
            }
            {
                Console.WriteLine("No");
            }
        }
    }
}

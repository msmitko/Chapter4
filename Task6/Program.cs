using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
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

            double greater = Math.Max(a, b);

            Console.WriteLine(greater);
        }
    }
}

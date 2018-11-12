using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            string input = Console.ReadLine();
            int integer = int.Parse(input);

            input = Console.ReadLine();
            double positiveRealNumber = double.Parse(input);

            input = Console.ReadLine();
            double negativeRealNumber = double.Parse(input);

            Console.WriteLine("{0,-10:X}{1,-10:F2}{2,-10:F2}", integer, positiveRealNumber, negativeRealNumber);
        }
    }
}

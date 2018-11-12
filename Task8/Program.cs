using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            decimal greatest = int.MinValue;
            string input = String.Empty;

            for (int i = 1; i <= 5; i++)
            {
                input = Console.ReadLine();
                decimal number = decimal.Parse(input);

                if (number > greatest)
                {
                    greatest = number;
                }
            }

            Console.WriteLine(greatest);
        }
    }
}

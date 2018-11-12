using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            decimal number;
            decimal sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                string input;
                do
                {
                    input = Console.ReadLine();
                }
                while (!decimal.TryParse(input, out number));

                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}

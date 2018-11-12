using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            double sum = 1;
            double oldSum = 0;

            for (int i = 2; Math.Abs(sum - oldSum) > 0.001; i++)
            {
                oldSum = sum;
                sum = sum + 1.0 / i;
            }

            Console.WriteLine("{0:F3}", sum);
        }
    }
}

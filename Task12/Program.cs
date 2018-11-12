using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            double a1 = 0;
            double b2 = 1;

            if (n == 1)
            {
                Console.WriteLine(a1);
            }

            if (n == 2)
            {
                Console.WriteLine(a1);
                Console.WriteLine(b2);
            }

            if (n > 2)
            {
                Console.WriteLine(a1);
                Console.WriteLine(b2);

                for (int i = 2; i < n; i++)
                {
                    double sum = a1 + b2;
                    if (i % 2 == 0)
                    {
                        a1 = sum;
                    }
                    else
                    {
                        b2 = sum;
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}

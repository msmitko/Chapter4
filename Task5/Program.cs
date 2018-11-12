using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int integer1 = int.Parse(input);

            input = Console.ReadLine();
            int integer2 = int.Parse(input);

            if (integer1 > integer2)
            {
                int temp = integer1;
                integer1 = integer2;
                integer2 = temp;
            }

            int numbersCount = 0;
            for (long i = integer1; i <= integer2; i++)
            {
                if (i % 5 == 0)
                {
                    numbersCount++;
                }
            }
            Console.WriteLine(numbersCount);
        }
    }
}

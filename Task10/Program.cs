using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                int number = int.Parse(input);
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
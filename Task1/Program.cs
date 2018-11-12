using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int integer99 = int.Parse(input);

        input = Console.ReadLine();
        int integer69 = int.Parse(input);

        input = Console.ReadLine();
        int integer68 = int.Parse(input);

        long sum = (long)integer99 + integer69 + integer68;

        Console.WriteLine(sum);
    }
}
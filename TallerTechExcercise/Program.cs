using System;

namespace TallerTechExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new CrazyCalulator();
            var result = calc.SumReverse(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 });
            Console.WriteLine($"The Sum Reverse is: {result}");

            Console.ReadLine();
        }
    }
}

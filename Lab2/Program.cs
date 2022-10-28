using System;
namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            if (k < 0)
            {
                Console.WriteLine("Mistake");
            }
            else
            {
                double expression = (Math.Pow(-1, k) + k + 8) / (2 * (Math.Pow(k, 2)) + k + 7);
                Console.WriteLine(expression);
            }
        }
    }
}
using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Distance , speed 1 and speed 2 :");
            int S = int.Parse(Console.ReadLine());
            int v1=int.Parse(Console.ReadLine());
            int v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Given info about the problem");
            Console.WriteLine("Distance = "+ S + "km/h");
            Console.WriteLine("First car's speed = " + v1 + "km/h");
            Console.WriteLine("Second car's speed = " + v2 + "km/h");
            int v = v1 + v2;
            int t = S / v;
            Console.WriteLine("Loading..%__________________ ");
            Console.WriteLine("cars will meet in "+ t + "h");
        }
    }
}

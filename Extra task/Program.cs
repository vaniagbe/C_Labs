using System;
namespace HoMEwork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double a, b, c, perimeter;
            int stepen = 2;
            Console.WriteLine("Enter first side :");
            str = Console.ReadLine();
            a = Convert.ToDouble(str);
            Console.WriteLine("Enter second side :");
            str = Console.ReadLine();
            b = Convert.ToDouble(str);
            Console.WriteLine("Enter hypotenuse side :");
            str = Console.ReadLine();
            c = Convert.ToDouble(str);
            double g = Math.Pow(c, stepen);
            double g1 = Math.Pow(a, stepen);
            double g2 = Math.Pow(b, stepen);
            if (g == g1 + g2)
            {
                perimeter = 0.5 * (a * b);
                Console.WriteLine(perimeter);
            }
            else
            {
                Console.WriteLine("It's not a rectangular triangle");
            }
        }
    }
}
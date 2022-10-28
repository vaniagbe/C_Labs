using System;
using System.Linq;
namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of array :");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Min());
        }
    }
}
    


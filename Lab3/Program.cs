﻿using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values for a three-digit number : ");
            uint firstValue = uint.Parse(Console.ReadLine());
            uint secondValue = uint.Parse(Console.ReadLine());
            uint thirdValue = uint.Parse(Console.ReadLine());
            Console.Write("Your number is : ");
            Console.Write(firstValue);
            Console.Write(secondValue);
            Console.Write(thirdValue);
            Console.WriteLine();
            if (firstValue<secondValue && secondValue<thirdValue)
            {
               Console.WriteLine("the sequence is increasing");
            }
            else if (firstValue > secondValue && secondValue > thirdValue)
            {
                Console.WriteLine("the sequence is decreasing");
            }
            else
            {
                Console.WriteLine("Mistake: there is no sequence");
            }
        }
    }
}

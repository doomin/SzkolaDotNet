using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;

namespace SzkolaDotNet.Week2.src
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Number num = new Number();            
            int resultPrimes = num.CountPrimesInRange(1, 100);
            Console.WriteLine($"Between 1 and 100 there are {resultPrimes} primes");

            int resultEvens = num.CountEvensInRange(1, 1000);
            Console.WriteLine($"Between 1 and 1000 there are {resultEvens} evens");

            List<int> resultEvenList = num.ReturnAllEvensInRange(1, 1000);
            foreach(int element in resultEvenList)
            {
                Console.Write($"{element} ");
            }

            int fibLength;
            Console.WriteLine($"\nProvide Fibonacci sequence length: ");
            int.TryParse(Console.ReadLine(), out fibLength);

            List<int> fibSeq = num.FibonacciSequence(fibLength);
            foreach(int element in fibSeq)
            {
                Console.Write($"{element} ");
            }

            int pyramid;
            Console.WriteLine($"\nProvide a number for a pyramid: ");
            int.TryParse(Console.ReadLine(), out pyramid);
            int counter = 1;
            int supp = 0;
            for(int i = 1; i<=pyramid; i++)
            {
                 Console.Write(i);
                if( i == counter+supp)
                {
                    Console.Write($"\n");
                    supp = supp + 1;
                    counter += supp;
                }
            }       
            
            Console.WriteLine("\nNumber for power 3 calculation");
            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine(num.ReturnPowerThree(i));
            }

            Console.WriteLine("\nFractions sum");
            double sum = 1.0;
            for (double i = 2.0; i <= 20.0; i++)
            {
                sum += 1/i;
            }            
            Console.WriteLine($"Sum of fractions is {sum:N10}");

            int a, b, c;

            Console.Write("\n\n");
            Console.Write("Display the pattern like diamond:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows (half of the diamond) :");
            c = Convert.ToInt32(Console.ReadLine());
            for (a = 0; a <= c; a++)
            {
                for (b = 1; b <= c - a; b++)
                    Console.Write(" ");
                for (b = 1; b <= 2 * a - 1; b++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (a = c - 1; a >= 1; a--)
            {
                for (b = 1; b <= c - a; b++)
                    Console.Write(" ");
                for (b = 1; b <= 2 * a - 1; b++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}

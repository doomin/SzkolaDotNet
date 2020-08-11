using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SzkolaDotNet.Week2
{
    public class Number
    { 
        public bool CheckIfIsPrime(int n)
        {
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int ReturnPowerThree(int number)
        {
            return (int)Math.Pow(number, 3);
        }

        public bool IsEven(int number)
        {
            if(number%2 == 0)
            {
                return true;
            }
            return false;
        }

        public int CountPrimesInRange(int start, int end)
        {
            int counter = 0;
            while(start <= end)
            {
                if(start == 2)
                {
                    start++;
                }
                if (CheckIfIsPrime(start))
                {
                    counter++;
                };
                start++;
            }
            return counter;
        }

        public int CountEvensInRange(int start, int end)
        {
            int counter = 0;
            do
            {
                if(start%2 == 0)
                {
                    counter++; 
                }
                start++;
            } while (start <= end);
            return counter;
        }

        public List<int> ReturnAllEvensInRange(int start, int end)
        {
            List<int> evens = new List<int>();
            do
            {
                if (start % 2 == 0)
                {
                    evens.Add(start);
                }
                start++;
            } while (start <= end);
            return evens;
        }

        public List<int> FibonacciSequence(int len)
        {
            List<int> result = new List<int>() {0, 1};

            int a = 0, b = 1, c = 0;
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                result.Add(c);
                a = b;
                b = c;
            }
            return result;
        }
    }
}

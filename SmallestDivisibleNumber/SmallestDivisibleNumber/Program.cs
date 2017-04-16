using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDivisibleNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                long n = Convert.ToInt64(input);
                var number = FindTheSmallestNumber(n);
               Console.WriteLine("Shortest Number Divisible by all the number from 1 to " + n + " = " +  number);
            }
            Console.Read();

        }



        private static long FindTheSmallestNumber(long n)
        {
            long shortestNumber = 1;

            for(int i=1; i<= n; i++)
            {
                shortestNumber = FindTheMultiplier(shortestNumber, i);
            }
            return shortestNumber;

        }

        private static long FindTheMultiplier(long shortestNumber, long eachIterator)
        {
            return (shortestNumber * eachIterator) / RecursiveDivider(shortestNumber, eachIterator);
        }


        private static long RecursiveDivider(long shortestNumber, long eachIterator)
        {
            if (eachIterator == 0)
            {
                return shortestNumber;
            }
            else
            {
                return RecursiveDivider(eachIterator, shortestNumber % eachIterator);
            }
        }

     }
}


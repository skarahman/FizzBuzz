using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            DoFizzBuzz();
            Console.ReadKey();
        }
        public static void DoFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                    Console.WriteLine(i+" FizzBuzz");
                else if (fizz)
                    Console.WriteLine(i+" Fizz");
                else if (buzz)
                    Console.WriteLine(i+" Buzz");
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

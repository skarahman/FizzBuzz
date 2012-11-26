﻿using System;
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
                if (fizz)
                    Console.WriteLine("Fizz");
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

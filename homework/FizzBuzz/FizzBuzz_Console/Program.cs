using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz_DLL;
using CheckNumber;

namespace FizzBuzz_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first value: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the last value: ");
            int finish = int.Parse(Console.ReadLine());

            Console.Write("Enter the first factor (Fizz): ");
            int factor1 = int.Parse(Console.ReadLine());
            while (Checker.CheckNum(factor1) == false)
            {
                Console.Write("Entered value is not a prime number, please try again: ");
                factor1 = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the second factor (Buzz): ");
            int factor2 = int.Parse(Console.ReadLine());
            while (Checker.CheckNum(factor2) == false)
            {
                Console.Write("Entered value is not a prime number, please try again: ");
                factor2 = int.Parse(Console.ReadLine());
            }

            FizzBuzzLogic.Main(start, finish, factor1, factor2);

            Console.ReadKey();
        }
    }
}

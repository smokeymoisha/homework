using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skiers_DLL;

namespace Skiers_Console
{
    class Program
    {
        public static double InputValidation(string str)
        {
            double result;
            while ((double.TryParse(str, out result)) == false || result < 0)
            {
                Console.Write("The entered value is not valid, please try again: ");
                str = Console.ReadLine();
            }
            return result;
        }

        static void Main(string[] args)
        {
            var daysTotal = new List<int>();
            string input;
            do
            {
                Console.Write("Enter X (the number of km the sportsman ran the 1st day): ");
                double x = InputValidation(Console.ReadLine());

                Console.Write("Enter Y (%): ");
                double y = InputValidation(Console.ReadLine());

                Console.Write("Enter Z (How many km the sportsman should run in total): ");
                double z = InputValidation(Console.ReadLine());

                int days = SkiersMath.Days(x, y, z);
                daysTotal.Add(days);

                Console.WriteLine($"In total, the sportsman will run {z} km in {days} days");
                Console.WriteLine("========================================");

                do
                {
                    Console.Write("Type 'yes' if you want to try again; 'results' if you want to see the previous results: ");
                    input = Console.ReadLine().ToLower();

                    if (input == "results")
                    {
                        daysTotal.ForEach(Console.WriteLine);
                    }
                }
                while (input == "results");
            }
            while (input == "yes");

            Console.ReadKey();
        }
    }
}

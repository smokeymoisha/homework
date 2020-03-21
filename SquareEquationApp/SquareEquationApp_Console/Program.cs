using SquareEquationApp_dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEquationApp_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ax^2 + bx + c = 0");

            Console.Write("Enter a: ");
            var aString = Console.ReadLine();
            double a = InputValidation.CheckValidity(aString);         

            Console.Write("Enter b: ");
            var bString = Console.ReadLine();
            double b = InputValidation.CheckValidity(bString);

            Console.Write("Enter c: ");
            var cString = Console.ReadLine();
            double c = InputValidation.CheckValidity(cString);

            var discriminant = SquareEquationMath.Discriminant(a, b, c);
            Console.WriteLine($"Discriminant = {discriminant}");

            if (discriminant == 0)
            {
                var firstRoot = SquareEquationMath.FirstRoot(discriminant, a, b);

                Console.WriteLine("Equation has 1 root");
                Console.WriteLine($"x1 = {firstRoot:F2}");

                Console.WriteLine($"{a}x^2 + {b}x + {c} = {a}*(x - {firstRoot:F2})*(x - {firstRoot:F2})");
            } if (discriminant > 0)
            {
                var firstRoot = SquareEquationMath.FirstRoot(discriminant, a, b);
                var secondRoot = SquareEquationMath.SecondRoot(discriminant, a, b);

                Console.WriteLine("Equation has 2 roots");
                Console.WriteLine($"x1 = {firstRoot:F2}");
                Console.WriteLine($"x2 = {secondRoot:F2}");

                Console.WriteLine($"{a}x^2 + {b}x + {c} = {a}*(x - {firstRoot:F2})*(x - {secondRoot:F2})");
            } if (discriminant < 0)
            {
                Console.WriteLine("Equation has no roots");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEquationApp_dll
{
    public class InputValidation
    {
        public static double CheckValidity(string input)
        {
            double number;
            while (double.TryParse(input, out number) == false)
            {
                Console.Write("Supplied value is not a number, please try again: ");
                input = Console.ReadLine();
            }
            return number;
        }
    }
}

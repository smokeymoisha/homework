using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEquationApp_dll
{
    public class SquareEquationMath
    {
        public static double Discriminant(double a, double b, double c)
        {
            var dscrm = Math.Pow(b, 2) - 4 * a * c;
            return dscrm;
        }

        public static double FirstRoot(double dscrm, double a, double b)
        {
            var x1 = (-b + Math.Sqrt(dscrm)) / (2 * a);
            return x1;
        }

        public static double SecondRoot(double dscrm, double a, double b)
        {
            var x2 = (-b - Math.Sqrt(dscrm)) / (2 * a);
            return x2;
        }
    }
}

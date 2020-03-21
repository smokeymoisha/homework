using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skiers_DLL
{
    public class SkiersMath
    {
        public static int Days(double x, double y, double z)
        {
            int day = 1;
            double km = x;
            while (km <= z)
            {
                if (day != 1 && day % 2 != 0)
                {
                    x = x + (x / 100) * y;
                    km = km + x;
                }
                if (km >= z) break;
                day++;
            }
            return day;
        }
    }
}

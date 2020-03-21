using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_DLL
{
    public class FizzBuzzLogic
    {
        public static void Main(int start, int finish, int factor1, int factor2)
        {
            for (int i = start; i <= finish; i++)
            {
                string result = i.ToString();
                if (i % factor1 == 0)
                {
                    result = "Fizz";
                    if (i % factor2 == 0)
                    {
                        result = "FizzBuzz";
                    }
                }
                else if (i % factor2 == 0)
                {
                    result = "Buzz";
                }

                Console.WriteLine(result);
            }
        }
    }
}

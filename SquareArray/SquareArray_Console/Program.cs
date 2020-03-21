using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareArray_Library;

namespace SquareArray_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int size;
            int[,] array = null;

            do
            {
                Console.WriteLine("======================= MENU =======================");
                Console.WriteLine("'new' to create a new array.");
                Console.WriteLine("'print' to print the created array.");
                Console.WriteLine("'trans' if you want to transpose the created array.");
                Console.WriteLine("'upper' to form an upper triangle matrix from the created array.");
                Console.WriteLine("'lower' to from a lower triangle matrix from the created array.");
                Console.WriteLine("'end' to finish working with the app.");

                input = Console.ReadLine().ToLower();

                if (input.Equals("new"))
                {
                    Console.Write("Enter the size of the square array: ");
                    size = int.Parse(Console.ReadLine());

                    array = SquareArray.Create(size);
                }
                else if (input.Equals("print"))
                {
                    if (array != null)
                    {
                        PrintSquareArray(array);
                    }
                    else
                    {
                        Console.WriteLine("You haven't created any arrays yet!");
                    }                   
                }
                else if (input.Equals("trans"))
                {
                    SquareArray.Transpose(array);
                }
                else if (input.Equals("upper"))
                {
                    SquareArray.UpperTriangle(array);
                }
                else if (input.Equals("lower"))
                {
                    SquareArray.LowerTriangle(array);
                }

                Console.WriteLine();

            } while (input.Equals("end") == false);

            Console.ReadKey();
        }

        static void PrintSquareArray(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int i2 = 0; i2 < columns; i2++)
                {
                    Console.Write($"{array[i, i2]} \t");
                }

                Console.WriteLine();
            }
        }
    }
}

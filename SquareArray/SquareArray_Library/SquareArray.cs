using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArray_Library
{
    public class SquareArray
    {
        public static int[,] Create(int size)
        {
            int[,] array = new int[size, size];

            Random rand = new Random();

            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    array[row, column] = rand.Next(1, 100);
                }
            }

            return array;
        }
        
        public static int[,] Transpose(int[,] array)
        {
            int size = array.GetUpperBound(0) + 1;
            int tmp;

            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < row; column++)
                {
                    tmp = array[row, column];
                    array[row, column] = array[column, row];
                    array[column, row] = tmp;
                }
            }

            return array;
        }

        public static int[,] UpperTriangle(int[,] array)
        {
            int size = array.GetUpperBound(0) + 1;

            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < row; column++)
                {
                    if (row > column) { array[row, column] = 0; }
                }
            }

            return array;
        }

        public static int[,] LowerTriangle(int[,] array)
        {
            int size = array.GetUpperBound(0) + 1;

            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < row; column++)
                {
                    if (row < column) { array[row, column] = 0; }
                }
            }

            return array;
        }
    }
}

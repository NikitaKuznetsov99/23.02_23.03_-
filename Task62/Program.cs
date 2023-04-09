// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void _print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j < matrix.GetLength(1) - 1)
                        Console.Write(matrix[i, j] + " ");
                    else
                        Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];

            int num = 1;
            int i = 0;
            int j = 0;

            while (num <= 16)
            {
                arr[i, j] = num;
                if (i <= j + 1 && i + j < 3)
                    ++j;
                else if (i < j && i + j >= 3)
                    ++i;
                else if (i >= j && i + j > 3)
                    --j;
                else
                    --i;
                ++num;
            }

            _print(arr);
            Console.ReadLine();

        }
    }
}
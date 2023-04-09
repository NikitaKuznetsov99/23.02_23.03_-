// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static Random rnd = new Random();
        static int[,] _create(int row, int col, int min, int max)
        {
            int[,] matrix = new int[row, col];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(min, max + 1);
                }
            }
            return matrix;
        }
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
        static int[,] _multi(int[,] matrix1, int[,] matrix2)
        {
            var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            if (matrix1.GetLength(1) == matrix2.GetLength(0))
            {
                for (int i = 0; i < matrix3.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix3.GetLength(1); j++)
                    {
                        matrix3[i, j] = 0;
                        for (int n = 0; n < matrix1.GetLength(1); n++)
                        {
                            matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                        }
                    }
                }
            }
            return matrix3;
        }
        static void Main(string[] args)
        {
            int[,] matr1 = _create(rnd.Next(3, 5), rnd.Next(3, 5), 0, 5);
            int[,] matr2 = _create(rnd.Next(3, 5), rnd.Next(3, 5), 0, 5);
            Console.WriteLine("Первая матрица: ");
            _print(matr1);
            Console.WriteLine("Вторая матрица: ");
            _print(matr2);
            Console.WriteLine("Матрица после перемножения");
            _print(_multi(matr1, matr2));
            Console.ReadLine();
        }
    }
}
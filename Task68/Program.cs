// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static int Recurs(int M, int N)
        {
            if (M == 0)
                return N + 1;
            else if (N == 0)
                return Recurs(M - 1, 1);
            else return
            Recurs(M - 1, Recurs(M, N - 1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите M");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите N");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Recurs(M, N));
            Console.ReadLine();

        }
    }
}
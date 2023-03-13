// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите L");
int L = Convert.ToInt32(Console.ReadLine());

int max = M;
if (N>M)
    max = N;
if (L>max)
    max = L;

Console.WriteLine(max + " наибольшее");

Console.ReadLine();
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

using System;
class HelloWorld {
static void Main() {
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());


double[,] a = new double[m, n];
Random random = new Random();

for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
a[i, j] = random.NextDouble();
Console.Write(a[i, j] + " ");
}
Console.WriteLine();
}

Console.WriteLine("Введите первую позицию: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую позицию: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x<m && x>=0 && y<n && y>=0)
{
Console.WriteLine(a[x,y]);
}
else
Console.WriteLine("такого элемента в массиве нет");

}
}
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
class HelloWorld {
static void Main() {
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] a = new int[m, n];
Random random = new Random();

for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
a[i, j] = random.Next(0,9);
Console.Write(a[i, j] + " ");
}
Console.WriteLine();
}

for (int j = 0;j<n;j++)
{
double sum = 0;
for (int i = 0;i<m;i++)
{
sum+=a[i,j];
}
Console.WriteLine(Convert.ToDouble(sum/m));
}


}
}
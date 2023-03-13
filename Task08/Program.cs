// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
        Console.WriteLine(i);
}

Console.ReadLine();
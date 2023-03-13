// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N)
    Console.WriteLine(M + " наибольшее");
else if (N > M)
    Console.WriteLine(N + " наибольшее");

Console.ReadLine();
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
int sum = 0;

Random random = new Random();

for (int i = 0; i < N; i++)
    array[i] = random.Next(1,12);

for (int i = 0; i < N; i++)
    Console.Write(array[i] + " ");

for (int i = 0; i < N; i++)
{
    if (i%2!=0)
        sum+= array[i];
}

Console.WriteLine();
Console.WriteLine(sum);
Console.ReadLine();

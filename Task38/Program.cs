// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


// Console.WriteLine("Введите размерность массива");
// int N = Convert.ToInt32(Console.ReadLine());

// double[] array = new double[N];
// double diff = 0;
// double max = 0;
// double min = 0;

// Random random = new Random();

// for (int i = 0; i < N; i++)
//     array[i] = random.NextDouble();

// for (int i = 0; i < N; i++)
//     Console.Write(array[i] + " ");

// max = array[0];
// min = array[0];
// for (int i = 0; i < N; i++)
// {
//     if (array[i] > max)
//         max = array[i];
//     if (array[i] < min)
//         min = array[i];
// }

// diff = max - min;
// Console.WriteLine();
// Console.WriteLine(diff);
// Console.ReadLine();

Console.WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine()); // Задали массив
int [] mass  = new int[n];      // Создаём мас
Random rnd = new Random();      // Создание объекта для генерации чисел
for (int i = 0; i < n; i++)
    { mass[i] = rnd.Next(-50, 50);  // Заполнение рандомами
    Console.Write($" {mass[i]} ");
}
int min = 0;
int max = 0;
foreach (int i in mass)  // Поиск максимального и минимального значения
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


// Console.WriteLine("Введите размерность массива");
// int N = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[N];

// for (int i = 0; i < N; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < N; i++)
//     Console.Write(array[i] + " ");

int[] a = Enumerable.Range(1, 8).Select(x => 17 % x).ToArray(); 
foreach (int i in a)
  Console.WriteLine(i);
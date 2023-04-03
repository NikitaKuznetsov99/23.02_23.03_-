// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

???
// using System;
// class HelloWorld
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите M");
//         int M = Convert.ToInt32(Console.ReadLine());

//         int count = 0;
//         int inp = 0;
//         for (int i = 1; i <= M; i++)
//         {
//             inp = Convert.ToInt32(Console.ReadLine());
//             if (inp > 0)
//                 count++;
//         }

//         Console.WriteLine(count);
//         Console.ReadLine();
//     }
// }
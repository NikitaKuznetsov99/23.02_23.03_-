﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите N");
string N = Console.ReadLine();

if (N[0] == N[4] && N[1] == N[3])
    Console.WriteLine("да");
else
    Console.WriteLine("нет");

Console.ReadLine();
﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int digit = number / 10 % 10;
Console.WriteLine ($"Вторая цифра трехзначного числа {digit}");
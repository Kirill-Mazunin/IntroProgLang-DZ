﻿ // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
 // Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трехзначное число ");
int n = int.Parse(Console.ReadLine()!);
int result = (n % 100) / 10;
Console.Write("Вторая цифра этого числа ");
Console.WriteLine(result);

﻿// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
Console.Write("Введите квадрат числа: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine());

int square = b * b;

if (a == square)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
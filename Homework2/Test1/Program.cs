// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5 456 / 10 % 10=5
// 782 -> 8
// 918 -> 1


Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result;

result = number / 10 % 10;
Console.WriteLine($"{number} -> {result}");

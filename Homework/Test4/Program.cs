﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int count = 2;
// while (count <= number)
// {
//     if(count % 2 == 0)
//     {
//         Console.Write($"{count}, ");
//     }
// count++;
// }
while (count <= number)
{
if (count % 2 == 0)
{
    Console.Write(count);
        if (count + 1 < number)
        {
            Console.Write(", ");
        }
}
count++;
}
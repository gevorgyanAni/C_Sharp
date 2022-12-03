﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();

int Digit(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FindPow(int number)
{
    int count = 1;
    while (count <= number)
    {
        int pow = count * count;
        Console.Write(pow + " ");
        count++;
    }
    Console.WriteLine();
}


int number = Digit("Введите число: ");
FindPow(number);
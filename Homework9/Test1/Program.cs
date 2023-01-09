// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int EnterNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int ReverseOrderOfNumbers(int number, int count)
{
        // System.Console.WriteLine($"{count} ");
        // count++;
        // ReverseOrderOfNumbers(number, count + 1);
        if (number == count)
            return number;
        else
            Console.Write($"{ReverseOrderOfNumbers(number, count + 1)}, ");
        return count;

}


int count = 1;
int number = EnterNumber("Введите число: ");

if (number < 1)
{
    Console.WriteLine("Неправильное число");
}
Console.WriteLine(ReverseOrderOfNumbers(number, count));
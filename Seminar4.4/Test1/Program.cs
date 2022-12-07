// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

int Digit(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int FindCount(int number)
{
    int count = 0;
    for(int i = 0; number > 0; i++)
    {
    number = number / 10;
    count++;
    }
    return count;
}

int number = Digit("Введите число: ");
int result = FindCount(number);
Console.WriteLine(result);


//2 вариант решения

// srting Digit(string str)
// {
//     Console.WriteLine(str);
//     string number = Console.ReadLine();
//     return number;
// }

// string number = Digit("Введите число: ");
// int result = number.Length;
// Console.WriteLine(result);

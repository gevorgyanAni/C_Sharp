// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int Digit(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumDigit(int num)
{
    int sum = 0;
    int result = 0;
    for (int i = 0; num > 0; i++)
    {
        result = num % 10;
        sum = sum + result;
        num = num / 10;
    }
    return sum;
}

int number = Digit("Введите число: ");
int result = SumDigit(number);
Console.WriteLine($"{number} -> {result}");
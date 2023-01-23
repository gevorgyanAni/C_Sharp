// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int EnterNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumNumbers(int number)
{
    int sum = 0;
    if (number > 0)
    {
        sum = sum + number % 10 + SumNumbers(number/10);
    }
    return sum;
}



int number = EnterNumber("Введите значение m: ");
int sum = SumNumbers(number);
System.Console.WriteLine(sum);
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
int TwoDigit(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int PowerDigit(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}

int number1 = TwoDigit("Введите 1 число: ");
int number2 = TwoDigit("Введите 2 число: ");
int result = PowerDigit(number1, number2);
Console.WriteLine($"{number1}, {number2}-> {result}");
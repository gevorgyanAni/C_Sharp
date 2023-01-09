// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int EnterNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void SumNumbers(int num1, int num2, int sum)
{
    
     sum = sum + num2;
     if (num2 <= num1)
    {
         Console.Write($"{sum} ");
         return;
     }
     SumNumbers(num1, num2 - 1, sum);
}


int number1 = EnterNumber("Введите значение m: ");
int number2 = EnterNumber("Введите значение n: ");
int sum = 0;
SumNumbers(number1, number2, sum);
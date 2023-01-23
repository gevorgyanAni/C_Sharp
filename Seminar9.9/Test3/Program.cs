// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int EnterNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int number = EnterNumber("Введите число: ");
int power = EnterNumber("Введите степень: ");
int sum = SumNumbers(number);
System.Console.WriteLine(sum);
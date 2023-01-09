// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int EnterNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Function(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Function(m - 1, 1);
    else
        return Function(m - 1, Function(m, n - 1));
}

int number1 = EnterNumber("Введите значение m: ");
int number2 = EnterNumber("Введите значение n: ");
int count = 0;
Console.WriteLine($"A({number1}, {number2}) = {Function(number1, number2)}");
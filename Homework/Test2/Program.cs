// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();
Console.Write("Введите l число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите 2 число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите 3 число: ");
int c = int.Parse(Console.ReadLine());

if ((a >= b) && (a >= c))
{
    Console.WriteLine($"{a}, {b}, {c} -> {a}");
}

if ((b >= a) && (b >= c))
{
    Console.WriteLine($"{a}, {b}, {c} -> {b}");
}

if ((c >= b) && (c >= a))
{
    Console.WriteLine($"{a}, {b}, {c} -> {c}");
}
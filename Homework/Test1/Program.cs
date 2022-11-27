// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
Console.Write("Введите l число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.Write($"max = {a}");
}
else
{
    Console.Write($"max = {b}");
}

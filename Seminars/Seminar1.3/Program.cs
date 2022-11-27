// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count;
if (number>0)
    {
        count = number*(-1);
        while (count <= number)
        {
            Console.Write($"{count}, ");
            count++;
        }
    }
else
{
    count = number;
    while (count <= number*(-1))
        {
            Console.Write($"{count}, ");
            count++;
        }
}
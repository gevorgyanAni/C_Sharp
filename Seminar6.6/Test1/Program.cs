// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.Clear();

int DataInput(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


void Triangle(int a, int b, int c)
{
    if ((a + b < c) || (c + b < a) || (a + c < b))
    {
        System.Console.WriteLine("It's Triangle");
    }
    else
    {
        System.Console.WriteLine("Not Triangle");
    }
}

int number1 = DataInput("Введите 1 число: ");
int number2 = DataInput("Введите 2 число: ");
int number3 = DataInput("Введите 3 число: ");
Triangle(number1, number2, number3);
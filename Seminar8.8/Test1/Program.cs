//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Clear();

void ChangeRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int buffer = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = buffer;
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }


}
int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return array;
}

int EnterNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int m = EnterNumber("Введите значение m: ");
int n = EnterNumber("Введите знаение n: ");

int[,] matrix = CreateRandomArray(m, n, 0, 10);

PrintArray(matrix);
System.Console.WriteLine();
ChangeRows(matrix);
PrintArray(matrix);
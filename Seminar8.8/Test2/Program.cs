//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void ChangeRowsAndColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int buffer =  array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = buffer;
        }
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
ChangeRowsAndColumns(matrix);
System.Console.WriteLine();
PrintArray(matrix);
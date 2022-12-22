// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();

const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

void FindingIndexValue(int[,] arr, int num)
{
    if (num <= arr.Length)
    {
        int count = 0;
        int rowsPosition = 0;
        int columnsPosition = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (count == num - 1)
                {
                    rowsPosition = i;
                    columnsPosition = j;
                    Console.WriteLine($"Index = ({i}, {j})");
                    count++;
                }
                else
                {
                    count++;
                }
            }
        }
    }
    else Console.WriteLine("No such meaning");

}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
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


int number = EnterNumber("Введите введите число: ");

int rows = EnterNumber("Введите количество строк: ");
int columns = EnterNumber("Введите количество столбцов: ");
int[,] matrix = CreateRandomArray(rows, columns, LEFT_RANGE, RIGHT_RANGE);

PrintArray(matrix);
FindingIndexValue(matrix, number);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

double[] AverageElement(int[,] matrix)
{
    double[]  arithmeticMean = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arithmeticMean[i] += matrix[j, i];

        }
        arithmeticMean[i] /= (double)matrix.GetLength(0);
        arithmeticMean[i] = Math.Round(arithmeticMean[i], 1);
    }
return arithmeticMean;
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


int rows = EnterNumber("Введите количество строк: ");
int columns = EnterNumber("Введите количество столбцов: ");

int[,] matrix = CreateRandomArray(rows, columns, 0, 10);

PrintArray(matrix);
double[] arithmeticMean = AverageElement(matrix);
Console.WriteLine($"{'(' + string.Join("; ", arithmeticMean) + ')'}");
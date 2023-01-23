// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int AddNumber(string str)
{
    System.Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// void FillMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 17);
//         }
//     }


void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }


}

void SpiralMatrix(int[,] array, int rowsMatrix, int columnsMatrix)
{
    int count = 1;
    int startCol = 0;
    int endCol = columnsMatrix - 1;
    int startRow = 0;
    int endRow = rowsMatrix - 1;
    while (startCol <= endCol && startRow <= endRow)
    {
        for (int i = startCol; i <= endCol; i++)
        {
            array[startRow, i] = count;
            count++;
        }
        startRow++;

        for (int j = startRow; j <= endRow; j++)
        {
            array[j, endCol] = count;
            count++;
        }
        endCol--;

        for (int i = endCol; i >= startCol; i--)
        {
            array[endRow, i] = count;
            count++;
        }
        endRow--;

        for (int j = endRow; j >= startRow; j--)
        {
            array[j, startCol] = count;
            count++;
        }
        startCol++;


    }

}



int rowsMatrix = AddNumber("Введите количесвто строк матрицы");
int columnsMatrix = AddNumber("Введите количесвто столбцов матрицы");
int[,] matrix = new int[rowsMatrix, columnsMatrix];
SpiralMatrix(matrix, rowsMatrix, columnsMatrix);
PrintMatrix(matrix);

int AddNumber(string str)
{
    System.Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;


}

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 6);
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

void MatrixMultiplication(int[,] first, int[,] second, int[,] multy)
{
    for (int i = 0; i < multy.GetLength(0); i++)
    {
        for (int j = 0; j < multy.GetLength(1); j++)
        {
            multy[i, j] = 0;
            for (int k = 0; k < first.GetLength(1); k++)
            {
               multy[i, j] += first[i, k] * second[k, j];
            }
        }
    }

}


int columnsFirstMatrix = AddNumber("Введите количесвто столбцов первой матрицы");
int rowsFirstMatrix = AddNumber("Введите количесвто линий первой матрицы");
int columnsSecondMatrix = AddNumber("Введите количесвто столбцов второй матрицы");
int rowsSecondMatrix = AddNumber("Введите количесвто линий второй матрицы");

if(columnsFirstMatrix == rowsSecondMatrix)
{
    int[,] firstMatrix = new int[columnsFirstMatrix, rowsFirstMatrix];
    int[,] secondMatrix = new int[columnsSecondMatrix, rowsSecondMatrix];
    FillMatrix(firstMatrix);
    FillMatrix(secondMatrix);
    PrintArray(firstMatrix);
    System.Console.WriteLine();
    PrintArray(secondMatrix);
    int[,] multyMatrix = new int [columnsFirstMatrix, rowsSecondMatrix];
    MatrixMultiplication(firstMatrix, secondMatrix, multyMatrix);
    System.Console.WriteLine();
    PrintArray(multyMatrix);
}
else
    System.Console.WriteLine("Матрицы нельзя перемножить");
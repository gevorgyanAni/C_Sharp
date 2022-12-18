//рзмер  m и n , каждый элемент в массиве находится по по вормелу  А =m+n
Console.Clear();

void PrintArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }


}
int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] =  i + j;
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

int[,] matrix = CreateArray(m, n);

PrintArray(matrix);
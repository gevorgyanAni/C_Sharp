//задайте массив из 12 элементов, заполненный случайными числами от -9 до 9. 
//Найти сумму отрицательных и положительных элементов массива
Console.Clear();


const int SIZE = 5;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 10;
int[] array = new int[SIZE];

Random rand = new Random();

int sumPositive = 0;
int sumNegative = 0;


int[] FilleArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1); //-9 до 10
    }
    return arr;
}

void SumPositiveAndNegative(int[] arr, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumP += arr[i];
        }
        else
        {
            sumN += arr[i];
        }
    }
}


array = FilleArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']'); //вводим массив через разделитель
SumPositiveAndNegative(array, out int sumP, out int sumN);
Console.WriteLine($"Сумма положительных элементов = {sumP}, отрицательных = {sumN}");
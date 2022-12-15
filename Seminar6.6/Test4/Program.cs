// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

Console.Clear();

const int SIZE = 8;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 99;

int[] array = new int[SIZE];

int[] FilleArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] CopyArray(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

array = FilleArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');
int[] secondArray = CopyArray(array);
Console.WriteLine('[' + string.Join(", ", secondArray) + ']');
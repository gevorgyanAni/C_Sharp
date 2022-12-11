// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

const int SIZE = 5;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 999;

int[] array = new int[SIZE];
Random ran = new Random();

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

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

array = FilleArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.Write('[' + string.Join(", ", array) + ']');
int result = CountEvenNumbers(array);
Console.WriteLine($" -> {result}");
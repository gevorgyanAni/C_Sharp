//Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

const int SIZE = 8;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 99;

double[] array = new double[SIZE];

double[] FilleArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.NextDouble()+ rand.Next(leftRange, rightRange + 1);
        arr[i] = Math.Round(arr[i], 2);
    }
    return arr;
}

void MaxMin(double[] arr, out double max, out double min)
{
    max = arr[0];
    min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }

}

array = FilleArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');
MaxMin(array, out double max, out double min);
Console.Write($" Max = {max}, min = {min}");
double result = max - min;
Console.WriteLine($" -> {Math.Round(result, 2)}");
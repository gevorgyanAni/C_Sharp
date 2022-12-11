//  Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();

const int SIZE = 5;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 10;
int[] array = new int[SIZE];

Random rand = new Random();

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

array = FilleArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');

for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();


const int SIZE = 123;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 500;

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

int count = 0;
for (int i = 0; i < array.Length; i++)
{   
    if((array[i] >= 10) && (array[i] <= 99))
    {
        count +=1;
    }
}

System.Console.WriteLine("Кол-во элементов = "  + count);





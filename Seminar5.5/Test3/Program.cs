// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

const int SIZE = 10;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 999;
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

System.Console.WriteLine("Enter a number:  ");
int number = int.Parse(Console.ReadLine());

bool result = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        result = true; 
        break;
    }

}
if (result)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}
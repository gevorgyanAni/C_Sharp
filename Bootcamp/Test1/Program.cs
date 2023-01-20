//array-10
//count = 3
// 1 4 9 9 4 6 8 4 2 3
//max = 22
//Создаем массив из 10 рандомных чисел
using System.Diagnostics;
Console.Clear();
const int SIZE = 10;
// const int LEFT_RANGE = 0;
// const int RIGHT_RANGE = 10;

//int[] array = new int[SIZE];

// int[] FilleArrayWithRandomNumbers(int size, int leftRange, int rightRange)
// {
//     Random rand = new Random();
//     int[] arr = new int[size];
//     for (int i = 0; i < SIZE; i++)
//     {
//         arr[i] = rand.Next(leftRange, rightRange + 1);
//     }
//     return arr;
// }
int m = 3;
int[] array = Enumerable.Range(1, SIZE)
                        .Select(item => Random.Shared.Next(10))
                        .ToArray();
System.Console.WriteLine($"[{string.Join(", ", array)}]");

Stopwatch sw = new();
sw.Start();

int max = 0;
for (int i = 0; i < array.Length - m; i++) //мы доходим до 10 -3, потому что последние элементы не смогут суммироваться по трем элементам. 
{
    int t = 0; //временная сумма
    for (int j = i; j < i + m; j++) //цикл, чтобы суммировал по три числа: от 0 до 3, от 1 до 4, от 2 до 5...
    {
        t = t + array[j];
    }
    if (t > max) max = t;
}

sw.Stop();
System.Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
System.Console.WriteLine(max);


int max1 = 0;
for (int j = 0; j < m; j++) max1 += array[j]; //посчитали сумму
int t1 = max1; //временная сумма
for (int i = 1; i < array.Length - m; i++)
{
    t1 = t1 - array[i -1] + array[i + (m - 1)];
    if (t1 > max1) max1 = t1;
}
System.Console.WriteLine(max1);
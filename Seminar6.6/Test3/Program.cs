// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();

int DataInput(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] ConverTof(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 2] + array[i - 1];

    }
    return array;

}

int number = DataInput("Введите N число: ");
int[] arr = ConverTof(number);
System.Console.WriteLine("[" + string.Join(",", arr) +"]");
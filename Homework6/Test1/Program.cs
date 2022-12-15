// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
Console.Clear();

int[] Digits(string str)
{
    Console.WriteLine(str);
    int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    return array;
}

int CountOfPositiveNumbers9(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }

    }
    return count;
}

int[] array = Digits("Введите числа через пробел: ");
int result = CountOfPositiveNumbers9(array);
System.Console.Write("- > " + result);
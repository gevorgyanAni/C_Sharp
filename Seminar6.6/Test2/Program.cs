// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();

int DataInput(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


void GetBinaryView(int num)
{
    if(num <=0)
    {
        return;
    }
    GetBinaryView(num/2);
    System.Console.WriteLine(num%2);
}

int number = DataInput("Введите 1 число: ");
GetBinaryView(number);
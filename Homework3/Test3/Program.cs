// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
int DataEntryN(string str)
{
    Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void CubeTable(double number)
{
    double count = 1;
    while (count <= number)
    {
        double result = Math.Pow(count, 3);
        Console.Write(result);
        if (count + 1 <= number)
        {
            Console.Write(", ");
        }
        count++;
    }
}


int num = DataEntryN("Введите число N: ");
CubeTable(num);
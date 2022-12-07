// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Digit(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int FindMulti(int number)
{
    int multi = 1;
    for(int i = 1; i <= number; i++)
    {
        multi = multi * i;
    }
    return multi;
}


int number = Digit("Введите число: ");
int result = FindMulti(number);
Console.WriteLine(result);
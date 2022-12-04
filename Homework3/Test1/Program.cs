// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

int Digit(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindPalindrome(int number)
{
    int date = 0;
    while (number > 0)
    {
        date = (date * 10) + (number % 10);
        number = number / 10;
    }
    return date;
}


int number = Digit("Введите число: ");
int Palindrome = FindPalindrome(number);
if (Palindrome == number)
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}






// int Digit(string str)
// {
//     Console.WriteLine(str);
//     int mass = int.Parse(Console.ReadLine());
//     return mass;
// }

// void FillArray(int[] collection) //collection - название аргумента
// {
//     int Length = collection.Length;
//     int index = 0;
//     while (index < Length)
//     {
//         collection[index] = mass;
//         index++;
//     }
// }


// void FindPalindrome



// int mass = Digit("Введите число: ");
// int[] array = new int[5];
// FillArray(array);
// FindPalindrome
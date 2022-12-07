//напишите программу , которая ввыводит массив из 8 элементов , заполненный нулями и 1 в рандомном порядке


// void PrintArray(int[] col);
// {
//     int count = col.Length;    //кол-во элементов = длинне массива
//     for(int i = 0; i < count; i++)
//     {
//         Console.WriteLine(col[i]+ " ");
//     }
// }
void FillArray(int[] collection) //collection - название аргумента
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(2);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(col[i] + " ");
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);

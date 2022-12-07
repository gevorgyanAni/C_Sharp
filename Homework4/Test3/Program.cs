// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();

void FillArray(int[] massive)
{
    int length = massive.Length;
    for (int i = 0; i < length; i++)
    {
        massive[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] massprint)
{
    int length = massprint.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(massprint[i] + " ");
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);

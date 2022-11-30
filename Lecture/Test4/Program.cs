void FillArray(int[] collection) //collection - название аргумента
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;    //кол-во элементов = длинне массива
    int position = 0;         //index
    while (position < count) //index< count
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array); // вызвали fill, заполняет массив, потому что поналачу массив щаполнен нулями
PrintArray(array); //вызвали print, распечатывает массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

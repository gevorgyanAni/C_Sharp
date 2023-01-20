System.Console.WriteLine("Введите количество элементов массива: ");
int n =  int.Parse(Console.ReadLine());

int[] array = new int[n];
for (int i = 0; i < n; i++)
{
  System.Console.WriteLine("Введите значения массива: ");
  array[i] = int.Parse(Console.ReadLine());
}
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine();

int count = 0;
for (int i = 0; i < n - 1 ; i++)
{
    for (int j = 0; j < n - 1 - i; j++)
    {
        System.Console.WriteLine($"сравниваем {array[j]} с {array[j + 1]}");
        if(array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
            count++;
        }
    }
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}
 System.Console.WriteLine(count);
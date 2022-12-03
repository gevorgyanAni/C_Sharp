Console.Clear();
int DataEntryXY(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FindQandrat(int x, int y)
{
    if ((x > 0) && (y > 0)) Console.WriteLine("1");
    if ((x < 0) && (y > 0)) Console.WriteLine("2");
    if ((x < 0) && (y < 0)) Console.WriteLine("3");
    if ((x > 0) && (y < 0)) Console.WriteLine("4");
}

int x = DataEntryXY("Введите коориданты x = ");
//Console.WriteLine(x);
int y = DataEntryXY("Введите коориданты y = ");
//Console.WriteLine(y);
FindQandrat(x, y);


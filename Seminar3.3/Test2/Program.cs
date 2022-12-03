//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек
//в этой четверти (x и y).
Console.Clear();
int DataEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;

}


void FindQuarter(int ch)
{
    if (ch == 1) Console.WriteLine("(x > 0)  (y > 0)");
    if (ch == 2) Console.WriteLine("(x < 0)  (y > 0)");
    if (ch == 3) Console.WriteLine("(x < 0)  (y < 0)");
    if (ch == 4) Console.WriteLine("(x > 0)  (y < 0)");
}


int ch = DataEntry("введите номер четверти = ");
FindQuarter(ch);

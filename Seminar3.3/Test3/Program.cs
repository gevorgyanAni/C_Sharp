//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21


int DataEntryXY(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double CalcDistance(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
    return result;
}


int x1 = DataEntryXY("Введите коориданты x1 = ");
int y1 = DataEntryXY("Введите коориданты y1 = ");

int x2 = DataEntryXY("Введите коориданты x2 = ");
int y2 = DataEntryXY("Введите коориданты y2 = ");

double result = CalcDistance(x1, y1, x2, y2);
Console.WriteLine(result);

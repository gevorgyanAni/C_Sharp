// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
int DataEnrtyXYZ(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double Distance = Math.Sqrt(Math.Pow((x2-x1), 2)+ Math.Pow((y2-y1), 2)+ Math.Pow((z2-z1), 2));
    return Distance;
}




int x1 = DataEnrtyXYZ("Введите координаты x1: ");
int y1 = DataEnrtyXYZ("Введите координаты y1: ");
int z1 = DataEnrtyXYZ("Введите координаты z1: ");

int x2 = DataEnrtyXYZ("Введите координаты х2: ");
int y2 = DataEnrtyXYZ("Введите координаты y2: ");
int z2 = DataEnrtyXYZ("Введите координаты z2: ");

double Distance = FindDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Distance);
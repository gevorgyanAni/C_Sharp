// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) //k1 *x + b1 = k2 * x + b2 //

Console.Clear();
double DataEnrtyXYZ(string str)
{
    Console.WriteLine(str);
    double number = double.Parse(Console.ReadLine());
    return number;
}

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Ответ - > ({x}, {y})");
}


double b1 = DataEnrtyXYZ("Введите координаты b1: ");
double k1 = DataEnrtyXYZ("Введите координаты k1: ");
double b2 = DataEnrtyXYZ("Введите координаты b2: ");
double k2 = DataEnrtyXYZ("Введите координаты k2: ");
IntersectionPoint(b1, k1, b2, k2);

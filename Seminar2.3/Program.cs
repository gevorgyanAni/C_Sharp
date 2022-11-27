int value1 = int.Parse(Console,ReadLine());
int value2 = int.Parse(Console.ReadLine());

double Pow1 = Math.Pow(value1, 2);
double Pow2 = Math.Pow(value1, 2);

if (value2 > value1)
{
    if (Pow1 == value2)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
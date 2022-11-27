// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятницa
Console.Clear();
Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());

if (number == 1) Console.WriteLine ("Пн");

if (number == 2) Console.WriteLine ("Вт");

if (number == 3) Console.WriteLine ("Ср");

if (number == 4) Console.WriteLine ("Чт");

if (number == 5) Console.WriteLine ("Пт");

if (number == 6) Console.WriteLine ("Сб");

if (number == 7) Console.WriteLine ("Вс");

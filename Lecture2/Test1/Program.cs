// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while ( i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

    for( int i = 1; i <= 10; i++)
    {
       for( int j = 2; j <=10; j++) 
       {
            Console.WriteLine($"{i} x {j} = {i * j}");
       }
       Console.WriteLine();
    }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);
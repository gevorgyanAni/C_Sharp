﻿// Дан текст. В нём нужно все пробелы заменить чёрточками,
//  маленькие буквы«к» заменить большими «К»,
//  а большие «С» заменить на маленькие «с».

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; //инциализация пустой строки
    int length = text.Length; //для того, чтобы получить длину нашей строки (св-во показывающее количество символов в строке)
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";

    }
    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s [3] // к

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ','|');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'к','К');
Console.WriteLine(newText);

// void GetSumNums(int number)
// {
//     int sum = 0;

//     for (int i = 1; i <= Math.Abs(number); i++) ;
//     {
//         sum += i;
//     }
//     Console.WriteLine($"сумма цифр от 1 до числа: {sum}");
// }
// Console.Clear();
// GetSumNums(16);

// void ToDegree(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(result);
// }


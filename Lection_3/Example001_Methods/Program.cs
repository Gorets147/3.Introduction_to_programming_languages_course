﻿// Вид 1
void Method1()
{
    System.Console.WriteLine("Автор...");
}



// Вид 2
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст", count: 4);



// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// System.Console.WriteLine(year);



// Вид 4
// string Method4(int count, string c)
// {
//     int i = 0;
//     string res = String.Empty;

//     while (i < count)
//     {
//         res = res + c;
//         i++;
//     }
//     return res;
// }

string Method4(int count, string c)
{
    string res = String.Empty;
    for (int i = 0; i < count; i++)
    {
        res = res + c;
    }
    return res;
}

// string res = Method4(10, "asdf");
// System.Console.WriteLine(res);



void Table(){
    for (int i = 2; i < 10; i++)
    {
        for (int j = 2; j <= 10; j++)
        {
            System.Console.WriteLine($"{i} x {j} = {i * j}");
        }
        System.Console.WriteLine();
    }
}

/*===== Работа с текстом
Дан текст. В тексте нужно все пробелы заменить чёрточками, 
маленькие буквы "к" заменить большими "К",
а большие "С" заменить маленькими "с".
*/
string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого "
            + "Винценгероде, вы бы взяли приступом согласие "
            + "прусского короля. Вы так красноречивы. Вы "
            + "дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }




    return result;
}

// string newText = Replace(text, ' ', '|');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replace(newText, 'C', 'c');
// System.Console.WriteLine(newText);


int[] arr = {1, 5, 2, 4, 3, 8, 3, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.WriteLine($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i ++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}



PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
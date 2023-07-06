/*
Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


void FillArray(int[] arr, int from, int to)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
}

int[] EightMass(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

System.Console.WriteLine("Enter a range [A,B) of numbers starting from the left border (A): ");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Right border (B): ");
int b = int.Parse(Console.ReadLine()!);
Console.Clear();

int[] numbers = new int[8];

FillArray(numbers, a, b);
PrintArray(numbers);



// void MassConf(int[] arr)
// {
//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = new Random().Next();
//     }
// }
// void PrintArray(int[] arr)
// {
//     var str = string.Join(" ", arr);
//     Console.Write($"{str} ");
// }

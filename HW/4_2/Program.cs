/*
Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


void FillArray(int[] arr, int num_1, int num_2)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(num_1, num_2);
    }
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
}

System.Console.WriteLine("Enter a range [A,B) of numbers starting from the left border (A): ");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Right border (B): ");
int b = int.Parse(Console.ReadLine()!);
Console.Clear();

int[] numbers = new int[8];

FillArray(numbers, a, b);
PrintArray(numbers);
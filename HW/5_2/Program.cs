/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");

    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++) arr[i] = Math.Round(rand.NextDouble() * 10, 2);
    return arr;
}

double DefferentMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[1];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    return max - min;
}

int num = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num);

Print(mass);
System.Console.WriteLine(Math.Round(DefferentMaxMin(mass), 2));
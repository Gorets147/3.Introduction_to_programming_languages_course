/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

double[,] FillArray(int rows, int colums, int from, int to)
{
    double[,] matr = new double[rows, colums];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(rand.NextDouble() * (to - from) + from, 2);
        }
    }
    return matr;
}

// double[] MassNums(int size)
// {
//     double[] arr = new double[size];
//     Random rand = new Random();

//     for (int i = 0; i < size; i++) arr[i] = Math.Round(rand.NextDouble() * 10, 2);
//     return arr;
// }


Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите минимальное число массива: ");
int start = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите максимальное число массива: ");
int stop = int.Parse(Console.ReadLine()!);

double[,] matrix = new double[m, n];

double[,] matrix2 = FillArray(m, n, start, stop);
PrintArray(matrix2);
/*
Задача 4. Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
*/

Console.Write("Кол-во строк матрицы: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов матрицы: ");
int col = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[row, col];

Console.Write("Введите минимальное значение элемента массива: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива: ");
int max = int.Parse(Console.ReadLine()!);

FillArray(matrix, min, max);
PrintMatrix(matrix);
System.Console.WriteLine();
int[] array = FindMinEl(matrix);
PrintMatrix(DelMinElRowCol(matrix, array));


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matrix, int min, int max)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
}

int[] FindMinEl(int[,] matr)
{
    int min = matr[0, 0];
    int[] minRowCol = new int[2];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (min > matr[i, j])
            {
                min = matr[i, j];
                minRowCol[0] = i;
                minRowCol[1] = j;
            }
        }
    }
    System.Console.WriteLine($"{minRowCol[0]}, {minRowCol[1]}");
    return minRowCol;
}


int[,] DelMinElRowCol(int[,] matr, int[] min_ind)
{
    int r = 0;
    int c = 0;
    int[,] resmatr = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (min_ind[0] != i && min_ind[1] != j)
            {
                resmatr[r, c] = matr[i, j];
                c++;
            }
        }
        c = 0;
        if (min_ind[0] != i) r++;
    }
    return resmatr;
}
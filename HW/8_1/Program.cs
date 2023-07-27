/*
Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Write("Кол-во строк ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов ");
int col = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[row, col];

Console.Write("Введите минимальное значение элемента массива : ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int max = int.Parse(Console.ReadLine()!);

FillArray(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
MinRowSum(matrix);

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

void FillArray(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
	    for (int j = 0; j < matrix.GetLength(1); j++)
	    {
	        matrix[i, j] = new Random().Next(min, max + 1);
	    }
	}
}

void MinRowSum(int[,] matr)
{
    int sum = 0;
    int[] RowSum = new int[row];
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        RowSum[i] = sum;
        sum = 0;
    }
    int minRow = 0;
    for (int i = 0; i < RowSum.Length; i++)
    {
        for (int j = i + 1; j < RowSum.Length; j++)
        {
            if (RowSum[i] < RowSum[j])
                {
                    minRow = i + 1;
                }
        }
    }
    System.Console.WriteLine($"Строка с минимальной суммой элементов № {minRow}");
}

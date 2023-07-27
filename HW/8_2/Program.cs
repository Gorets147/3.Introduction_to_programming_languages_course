/*
Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Write("Кол-во строк 1-й матрицы: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов 1-й матрицы: ");
int col1 = int.Parse(Console.ReadLine()!);
int[,] matrix1 = new int[row1, col1];
Console.Write("Кол-во строк 2-й матрицы: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов 2-й матрицы: ");
int col2 = int.Parse(Console.ReadLine()!);
int[,] matrix2 = new int[row2, col2];

Console.Write("Введите минимальное значение элемента массива: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива: ");
int max = int.Parse(Console.ReadLine()!);

FillArray(matrix1, min, max);
FillArray(matrix2, min, max);
PrintMatrix(matrix1);
System.Console.WriteLine("*");
PrintMatrix(matrix2);
System.Console.WriteLine();
PrintMatrix(MultMatrix(matrix1, matrix2));


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

int[,] MultMatrix(int[,] matr1, int[,] matr2)
{
    int[,] ResMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
    if (matr1.GetLength(1) != matr2.GetLength(0)) 
    {
        System.Console.WriteLine("Количество столбцов 1-й матрицы должно быть равно количеству строк 2-й матрицы");
        return ResMatr;
    }
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                ResMatr[i, j] += matr1[i, k] * matr2[k, j];
            }
        }

    }
    return ResMatr;
}
    
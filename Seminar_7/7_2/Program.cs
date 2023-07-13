// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.


void PrintArray(int[,] matr)
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

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }

}

int DiagonalSum(int[,] arr)
{
    int res = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        res += arr[i, i];
    }
    return res;
}


Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, m];

FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
System.Console.WriteLine(DiagonalSum(matrix));
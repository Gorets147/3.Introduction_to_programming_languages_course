

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
            matr[i, j] = new Random().Next(1,10);
        }
    }
}

int[,] CopyMatrix(int[,] matr)
{
    int[,] CopyMatr = new int[matr.GetLength(0), matr.GetLength(1)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            CopyMatr[i, j] = matr[i, j];
        }
        System.Console.WriteLine();
    }
    return CopyMatr;
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
int[,] matrix2 = CopyMatrix(matrix);

PrintArray(matrix);
PrintArray(matrix2);
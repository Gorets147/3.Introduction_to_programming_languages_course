

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



// Console.Write("Сколько чисел?");
// int M = int.Parse(Console.ReadLine()!);
// int res=0;

// for (int i = 1; i <= M; i++)
// {
//     Console.WriteLine($"Введите {i} число ");
//     int a = int.Parse(Console.ReadLine()!);
  
//     if (a==0)
//     {           
//                 Console.WriteLine("Введеное число равно 0");
//                 break;
//     } 
    
//     else if (a>0) res=res+1;
// }          
    


// Console.WriteLine($"Количество положительных чисел = {res} ");

// 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз 
//    встречается элемент входных данных. Значения элементов массива 0..9
//    https://metanit.com/sharp/tutorial/4.9.php

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
int[] array = FrequancyDictionary(matrix);
PrintArray(array);

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

int[] FrequancyDictionary(int[,] arr)
{
    int[] freq = new int[max + 1];

    foreach (int i in arr)
    {
        freq[i]++;
    }
    return freq;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0) System.Console.WriteLine($"{i} - {arr[i]}, ");
    }
}




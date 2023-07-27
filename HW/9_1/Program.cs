/*
Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

System.Console.WriteLine("Задайте промежуток от M до N. Введите M:");
int m = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine()!);
int sum = 0;
SumNum(m, n);
System.Console.WriteLine(sum);

void SumNum(int M, int N)
{
    if (M != N + 1)
    {
        sum += M;
        SumNum(M + 1, N);
    }
}
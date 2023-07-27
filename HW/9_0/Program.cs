/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
натуральные числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

System.Console.WriteLine("Задайте промежуток от M до N. Введите M:");
int m = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine()!);
EvenNum(m, n);

void EvenNum(int M, int N)
{
    if (M != N + 1)
    {
        if (M % 2 == 0) System.Console.WriteLine(M);
        EvenNum(M + 1, N);
    }
}
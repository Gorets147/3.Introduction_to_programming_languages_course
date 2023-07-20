// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.

void PrintNumber(int from, int to)
{
    if (to < from) return;
    PrintNumber(from, to - 1);
    System.Console.Write($"{to} ");
}
PrintNumber(4, 6);
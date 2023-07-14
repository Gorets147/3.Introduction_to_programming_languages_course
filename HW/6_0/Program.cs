/*
Задача 1: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

System.Console.WriteLine("How many numbers you will enter?");
int n = int.Parse(Console.ReadLine()!);

System.Console.WriteLine(CountNumbers(n));

int CountNumbers(int M)
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        System.Console.WriteLine($"Enter {i + 1} number");
        int num = int.Parse(Console.ReadLine()!);
        if (num > 0) count++;
    }
    return count;
}
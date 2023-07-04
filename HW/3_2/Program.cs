/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

System.Console.WriteLine("Enter the number: ");
int num = int.Parse(Console.ReadLine()!);
Cube(num);

void Cube(int n)
{
    
    if (n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(Math.Pow(i, 3));
        }
    }
    else
    {
        for (int i = -1; i >= n; i--)
        {
            Console.WriteLine(Math.Pow(i, 3));
        }
    }
}
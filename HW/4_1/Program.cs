/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


System.Console.WriteLine("Enter the number: ");
int a = int.Parse(Console.ReadLine()!);

int SummDig(int num)
{
    int res = 0;
    for (int i = 0; num != 0; i++)
    {
        res += num % 10;
        num = num / 10;
    }
    return res;
}

System.Console.WriteLine(SummDig(a));
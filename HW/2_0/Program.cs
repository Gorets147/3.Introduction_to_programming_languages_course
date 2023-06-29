// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int num = int.Parse(Console.ReadLine()!);
SecondDig(num);

void SecondDig(int num)
{
    System.Console.WriteLine(num);
    num = num / 10;
    num = num % 10;
    System.Console.WriteLine(num);
}

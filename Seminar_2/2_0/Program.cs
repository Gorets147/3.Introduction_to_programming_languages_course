// 0. Напишите программу, которая принимает на вход трёхзначное число
//    и на выходе показывает последнюю цифру этого числа.

int LastDig(int num)
{
    System.Console.WriteLine(num);
    return num % 10;
}

int th_num = new Random().Next(100, 1000);
int result = LastDig(th_num);
System.Console.WriteLine(result);
// 3. Напишите программу, которая на вход принимает одно число
//    (N), а на выходе показывает все целые числа в промежутке от -N до N.

int a = int.Parse(Console.ReadLine()!);
int count = -a;
    System.Console.WriteLine(count);
while (count != a)
{
    if (a > 0)
    count++;
    else
    count--;
    System.Console.WriteLine(count);
};

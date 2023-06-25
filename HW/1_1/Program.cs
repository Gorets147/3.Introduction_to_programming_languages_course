// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


System.Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
int min = 0;
int max = 0;


if (a > b) {
    min = b;
    max = a;
}else{
    min = a;
    max = b;
}

Console.WriteLine("Максимальное: " + max);
Console.WriteLine("Минимальное: " + min);
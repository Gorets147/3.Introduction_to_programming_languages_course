﻿System.Console.WriteLine("Введите число a: ");
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
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine()!);
int max = 0;

if (a > b){
    max = a;
} else {
    max = b;
}

if (c > max) {
    max = c;
}

System.Console.WriteLine("Максимальное: " + max);
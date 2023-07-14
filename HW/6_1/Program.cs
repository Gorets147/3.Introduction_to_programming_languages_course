/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

System.Console.WriteLine("Введите b1: ");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите k1: ");
int b = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите b2: ");
int c = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите k2: ");
int d = int.Parse(Console.ReadLine()!);

string FindPoint(double b1, double k1, double b2, double k2)
{
    double k_dif = k1 - k2;
    if (k_dif != 0)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * x) + b1;
        return $"({x}, {y})";
    } 
    else if (k1 == k2 && b1 == b2) return "Бесконечное число точек пересечения!";
    else return "Отсутствую точки пересечения";
}

System.Console.WriteLine(FindPoint(a, b, c, d));
/*
Задача 2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


double Demension3(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double res = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return res;
}
System.Console.WriteLine("Введите координаты 1 точки: ");
int x1 = int.Parse(Console.ReadLine()!);
int y1 = int.Parse(Console.ReadLine()!);
int z1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координаты 2 точки: ");
int x2 = int.Parse(Console.ReadLine()!);
int y2 = int.Parse(Console.ReadLine()!);
int z2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(Demension3(x1, y1, z1, x2, y2, z2));

// System.Console.WriteLine("Здесь результаты из задачи: ");
// Console.WriteLine(Demension3(3, 6, 8, 2, 1, -7));
// Console.WriteLine(Demension3(7, -5, 0, 1, -1, 9));
// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.

void CheckTriAngle(int side1, int side2, int side3)
{
    if(side1 < side2+side3 && side2 < side1+side3 && side3 < side2+side1)
    {
        System.Console.WriteLine("Yes");
    }
    else System.Console.WriteLine("No");
}


int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
CheckTriAngle(a, b, c);
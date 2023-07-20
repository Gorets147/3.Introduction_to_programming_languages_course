// 4. Напишите программу, которая на вход принимает два числа A и B,
//    и возводит число А в целую степень B с помощью рекурсии.

System.Console.WriteLine("Введите A: ");
int A = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine("Введите B: ");
int B = int.Parse(System.Console.ReadLine()!);

int Rec(int A, int B)
{
    if (B == 0) return 1;

    return Rec(A, B - 1) * A;
}

Rec(A, B);
Console.WriteLine($"{Rec(A, B)}");
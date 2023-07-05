/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

System.Console.WriteLine("Enter number (A) to be rased to a power: ");
int a = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Enter the power (B) of a number (A): ");
int b = int.Parse(Console.ReadLine()!);

double Exponentional(int num, int exp)
{
    if (exp == 0) return 1;
    else if (num == 0) return 0;
    double res = num;
    if (exp > 0){
        for (int i = 1; i < exp; i++)
        {
            res *= num;
        }
        return res;
    }
    else if (exp < 0)
    {
        for (int i = -1; i > exp; i--)
        {
            res *= num;
        }
        return 1/res;
    }
    return 0;
}

System.Console.WriteLine(Exponentional(a, b));
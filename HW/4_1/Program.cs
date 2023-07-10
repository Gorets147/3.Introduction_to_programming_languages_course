/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


System.Console.WriteLine("Enter the number: ");
int a = int.Parse(Console.ReadLine()!);

int SummDig(int num)
{
    int res = 0;
    for (int i = 0; num != 0; i++)
    {
        res += num % 10;
        num = num / 10;
    }
    return res;
}

System.Console.WriteLine(SummDig(a));



// --------------------------------- 3 вариант
// https://shwanoff.ru/char-c-sharp/


double DigitSum(int num)
{
    string n = num.ToString();
    int length = n.Length;
    double sum = 0;

    for (int i = 0; i < length; i++)
    {
        double m = char.GetNumericValue(n[i]);
        sum += m;
    }

    return sum;
}

int n = int.Parse(Console.ReadLine()!); ;

Console.WriteLine(DigitSum(n));

// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.

System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);


int FindAmount(int num)
{
    int count = 0;
    while (num != 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

System.Console.WriteLine(FindAmount(number));

// Console.WriteLine("Введите число");
// int Count (int num)
// {
//     int result=0;
//     for (int i = 1; num!=0; i++)
//     {
//         num/=10;
//         result=i;
//     }
// return result;
// }
// int A=int.Parse(Console.ReadLine());
// Console.WriteLine(Count(A));
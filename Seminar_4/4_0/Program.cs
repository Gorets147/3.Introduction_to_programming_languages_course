// Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.

System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int SummNums(int A)
{
    int all_sum = 0;
    for (int i = 0; i <= A; i++)
    {
        all_sum += i;
    }
    return all_sum;
}
System.Console.WriteLine(SummNums(num));

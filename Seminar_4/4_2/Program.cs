// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.


System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int SummNums(int A)
{
    int all_sum = 1;
    for (int i = 1; i <= A; i++)
    {
        all_sum *= i;
    }
    return all_sum;
}
System.Console.WriteLine(SummNums(num));
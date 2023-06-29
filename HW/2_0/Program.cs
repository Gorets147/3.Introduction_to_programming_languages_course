int num = int.Parse(Console.ReadLine()!);
SecondDig(num);

void SecondDig(int num)
{
    System.Console.WriteLine(num);
    num = num / 10;
    num = num % 10;
    System.Console.WriteLine(num);
}

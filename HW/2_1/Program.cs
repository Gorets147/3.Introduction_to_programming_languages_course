// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int num = int.Parse(Console.ReadLine()!);
CheckNumbers(num);

void CheckNumbers(int num)
{
    System.Console.WriteLine(num);
    int count = 1;
    int temp = num;
    if (num < 100) System.Console.WriteLine("3 digit is missing");
    while (temp != 0)      
    {
        temp = temp / 10;  
        count++;           
    }
    count = count - 3;     
    int ten = 1;         
    for (int i = 1; i < count; i++)
    {
        ten = ten * 10;     
    }
    num = num / ten % 10;
    System.Console.WriteLine(num);
}
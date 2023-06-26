// 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшею цифру числа.



int num = new Random().Next(10, 100);

int FindDig(int numbers)
{
    System.Console.WriteLine(numbers);
    int a = numbers / 10;
    int b = numbers % 10;
    if (a > b) return a;
    else return b;
}

System.Console.WriteLine(FindDig(num));
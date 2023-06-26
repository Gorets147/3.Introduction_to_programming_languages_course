// 3. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да


void Multiplicity(int num)
{
    System.Console.WriteLine(num);
    if (num % 7 == 0 && num % 23 == 0) System.Console.WriteLine("Yes");
    else System.Console.WriteLine("No");
}

int num = new Random().Next(10, 100);
Multiplicity(num);
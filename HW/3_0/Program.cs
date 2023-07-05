/* 
Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

string CheckPoli(int num)
{
    System.Console.WriteLine(num);
    int num_1_2 = num / 1000;
    int num_5 = num % 10;
    int num_4 = num / 10 % 10;
    // System.Console.WriteLine(num_1_2);
    // System.Console.WriteLine(num_5);
    // System.Console.WriteLine(num_4);
    if (num_1_2 == num_5 * 10 + num_4) return "Yes";
    else return "no";
}

System.Console.WriteLine(CheckPoli(14212));
System.Console.WriteLine(CheckPoli(12821));
System.Console.WriteLine(CheckPoli(23432));
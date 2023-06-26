// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num == 0) {
    Console.WriteLine("ОШИБКА");
} else if(num % 2 == 0) {
    Console.WriteLine("ЧЁТНОЕ");
} else {
    Console.WriteLine("НЕчётное");
}
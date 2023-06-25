System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num == 0) {
    Console.WriteLine("ОШИБКА");
} else if(num % 2 == 0) {
    Console.WriteLine("ЧЁТНОЕ");
} else {
    Console.WriteLine("НЕчётное");
}
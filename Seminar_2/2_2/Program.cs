double num1 = new Random().Next(10, 100);
double num2 = new Random().Next(1, 10);

void CheckNumbers(double a, double b)
{
    System.Console.WriteLine($"Числа: {a}, {b}");
    if (a % b == 0) System.Console.WriteLine("Числа кратны");
    else System.Console.WriteLine($"Не кратны, остаток: {a % b}");
}

CheckNumbers(num1, num2);

System.Console.WriteLine("Введите координату x: ");
double x = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координату y: ");
double y = double.Parse(Console.ReadLine()!);

void Quarters(double x, double y)
{
    if (x == 0 || y == 0) System.Console.WriteLine("Start of coordinats");
    else if (x > 0 && y > 0) System.Console.WriteLine("1-st quarter");
    else if (x < 0 && y > 0) System.Console.WriteLine("2-nd quarter");
    else if (x < 0 && y < 0) System.Console.WriteLine("3-rd quarter");
    else if (x > 0 && y < 0) System.Console.WriteLine("4-th quarter");
}
   

Quarters(x, y);
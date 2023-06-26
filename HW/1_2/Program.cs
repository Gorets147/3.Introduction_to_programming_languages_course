System.Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine()!);
int max = 0;

if (a > b){
    max = a;
} else {
    max = b;
}

if (c > max) {
    max = c;
}

System.Console.WriteLine("Максимальное: " + max);
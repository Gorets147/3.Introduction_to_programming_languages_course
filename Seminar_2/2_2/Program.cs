// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.

//    34, 5 -> не кратно, остаток 4
//    16, 4 -> кратно


void rem(int a, int b)
{
    System.Console.WriteLine($"Числа: {a}, {b}");
    if (a % b == 0)
        Console.WriteLine("Числа кратны");
    else 
    {  
         Console.WriteLine("Числа не кратны "+a % b);
    }
        
}
int numA = new Random().Next(10, 100);
int numB = new Random().Next(1, 10);
rem(numA, numB);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Enter day of the week number: ");
int day = int.Parse(Console.ReadLine()!);
DayOfWeek(day);

void DayOfWeek(int day)
{
    switch (day)
    {
        case 1:
            System.Console.WriteLine("Monday is working day");
            break;
        case 2:
            System.Console.WriteLine("Tuesday is working day");
            break;
        case 3:
            System.Console.WriteLine("Wednesday is working day");
            break;
        case 4:
            System.Console.WriteLine("Thursday is working day");
            break;
        case 5:
            System.Console.WriteLine("Friday is working day");
            break;
        case 6:
            System.Console.WriteLine("Saturday day off");
            break;
        case 7:
            System.Console.WriteLine("Sunday day off");
            break;
        default:
            System.Console.WriteLine("Error!");
            break;
    }
}
System.Console.WriteLine("Введите имя: ");
string name = Console.ReadLine();

if (name.ToLower() == "gorets"){
    Console.WriteLine("Привет, хозяин!!!");
}else{
    Console.Write("Привет, ");
    Console.WriteLine(name);
}
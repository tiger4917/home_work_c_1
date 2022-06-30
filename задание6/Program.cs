Console.WriteLine("Введите число :");
string a = Console.ReadLine();
if (a.Length >2)
{
Console.WriteLine($"{a}-> {a[2]}");
}
else 
{
    Console.WriteLine("Третьей цифры не существует");
}
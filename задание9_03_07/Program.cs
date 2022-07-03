Console.WriteLine("Введите число из 5 цифер: ");
string n = Console.ReadLine();
if (n.Length == 5)
{
    if (n[0] == n[4] || n[1] == n[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    Console.WriteLine("неправильный ввод");
}
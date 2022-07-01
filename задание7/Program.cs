Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Сегодня выходной");
    }
    else
    {
        Console.WriteLine("Сегодня рабочий день");
    }
}
else
{
    Console.WriteLine(" в неделе 7 дней ");
}
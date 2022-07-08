//Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.


Console.WriteLine("Введите число из 5 цифер: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100000 && n > 9999)
{
    int[] array = new int[5];
    for (int i = 0; i < 5; i++)
    {
        array[i] = n % 10;
        n = n / 10;
    }
    if (array[0] == array[4] && array[1] == array[3])
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

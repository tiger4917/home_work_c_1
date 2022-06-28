Console.WriteLine("Введите трехзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 100 && number <1000)
{
int firstNumber = number % 100;
int secondNumber = firstNumber / 10;
Console.WriteLine($"{number} -> {secondNumber}");
}
else 
{
Console.WriteLine("Неверно введено");
}
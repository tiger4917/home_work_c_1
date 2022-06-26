Console.WriteLine("Введите число1");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число3");
int firdNumber = Convert.ToInt32(Console.ReadLine());
int maxNumber = firstNumber;
if (secondNumber > maxNumber)
{
maxNumber = secondNumber;
}
if (firdNumber > maxNumber)
{
maxNumber = firdNumber;
}
Console.WriteLine($"Максимальное значение = {maxNumber} ");
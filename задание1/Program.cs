Console.WriteLine("ВВедите число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int maxNumber = firstNumber;


if(secondNumber > maxNumber)
{
maxNumber = secondNumber;
}
Console.WriteLine($"Максимальное значение = {maxNumber} ");




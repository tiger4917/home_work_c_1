// Задача №23 про возведение числа в натуральную степень через цикл
Console.WriteLine("Введите число А:  и введите желаемую степень B:");
double[] numbers = new double[2];  // 
for (int i = 0; i < 2; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
double result = Math.Pow(numbers[0], numbers[1]);

Console.WriteLine($"число {numbers[0]} , {numbers[1]} результат:{result}");
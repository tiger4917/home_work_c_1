// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int M = InputInt("Введите число М: ");
int N = InputInt("Введите число N: ");
int sum = Sum(N, 0, M);
Console.WriteLine(sum);

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int N, int sum, int currentNumber)
{
    if (currentNumber > N)
    {
        return sum;
    }
    else
    {
        return Sum(N, sum + currentNumber, currentNumber + 1);
    }
}
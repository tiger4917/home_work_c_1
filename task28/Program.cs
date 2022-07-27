// Задача 64: Задайте значения M и N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 5, 6, 7, 8""
int M = InputInt("Введите число М: ");
int N = InputInt("Введите число N: ");

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
for (int i = M; i <= N; i++)
{
    Console.Write(i + " ");
}


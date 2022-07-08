//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Input Number: ");
double num = Convert.ToInt32(Console.ReadLine());

for (int i =1; i<=num ; i ++ )
{
    double result = Math.Pow(i, 3);
    Console.Write( result + "  ");
}
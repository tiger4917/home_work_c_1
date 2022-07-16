//Напишите программу, которая найдёт точку пересечения двух прямых,
 //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 //значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = InputCoordinat("b1");
double k1 = InputCoordinat("k1");
double b2 = InputCoordinat("b2");
double k2 = InputCoordinat("k2");

if (k1==k2)
{
    Console.WriteLine("Прямые параллельны!");
}
else
{
    double x = CalculateX(b1, b2, k1, k2);
    double y = CalculateY(x, k1, b1);
    Console.Write($"Координаты пересечения прямых: ({x} ; {y})");
}

double InputCoordinat(string output)
{
    Console.WriteLine("Введите значение :  " + output );
    double coord = Convert.ToDouble(Console.ReadLine());
    return coord;
}

double CalculateX(double b1, double b2, double k1, double k2 )
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double CalculateY(double x, double k1, double b1)
{
    double y = k1 * x + b1;
    return y;
}
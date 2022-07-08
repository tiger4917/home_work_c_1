// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.  
// A (3,6,8); B (2,1,-7), -> 15.84
int x1 = InputInt("Введите X1: ");
int y1 = InputInt("Введите y1: ");
int z1 = InputInt("Введите z1: ");

int x2 = InputInt("Введите X2: ");
int y2 = InputInt("Введите y2: ");
int z2 = InputInt("Введите z2: ");

int distanceX = x2 - x1;
int distanceY = y2 - y1;
int distanceZ = z2 - z1;

double distance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
Console.WriteLine(distance);


int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
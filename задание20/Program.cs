//Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

int row = InputInt("Введите количество строк: ");
int column = InputInt("Введите количество столбцов: ");
int[,] array = new int[row, column];

FillArray(array);
PrintArray(array);

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
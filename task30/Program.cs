// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку 
//  с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int row = InputInt("Введите количество строк: ");
int column = InputInt("Введите количество столбцов: ");
int[,] array = new int[row, column];
int[] newArray = new int[row];
int minRow;
FillArray(array);
PrintArray(array);
Find(array);

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
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void Find(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            newArray[i] += array[i, j];

        }
        Console.Write(newArray[i] + " ");
    }
    int min = newArray[0];
    minRow = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] < min)
        {
            min = newArray[i];
            minRow = i;
        }
    }
    Console.Write(minRow + 1);
}
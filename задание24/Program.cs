// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2             1 5 8 5
// 5 9 2 3             4 9 4 2
// 8 4 2 4             7 2 2 6
// 5 2 6 7             2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int row = InputInt("Введите количество строк 1 массива: ");
int column = InputInt("Введите количество столбцов 1 массива:");
int row2 = InputInt("Введите количество строк 2 массива: ");
int column2 = InputInt("Введите количество столбцов 2 массива:");


int [,] array = new int [row,column];
int [,] array2 = new int[row2,column2];
int [,] array3 = new int[row,column];
FillArray(array);
PrintArray(array);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();

for (int i =0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array3[i,j] = array[i,j] * array2[i,j];
        Console.Write(array3[i,j] + " ");
    }
    Console.WriteLine();
}

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
            array [i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
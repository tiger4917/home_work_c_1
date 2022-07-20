/*Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента
  или же указание, что такого элемента нет.
  Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] array = new int[5, 5];

FillArray(array);
PrintArray(array);
SolveTask(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}

void SolveTask(int[,] array)
{
    Console.WriteLine("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца: ");
    int column = Convert.ToInt32(Console.ReadLine());

    if (row <= array.GetLength(0) && column <= array.GetLength(1))
    {
        Console.WriteLine($"Ваше значение : {array[row - 1, column - 1]}");
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет :(");
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
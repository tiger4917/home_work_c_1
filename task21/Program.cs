// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int row = InputInt("Введите количество строк: ");
int column = InputInt("Введите количество столбцов: ");
int [,] array =new int [row,column]; 
int [] newArray = new int [column];
FillArray(array);
PrintArray(array);
SortArray(newArray);

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

int SortArray(int newArray)
{
    for(int i = 0; i < newArray.Length; i++)
    {
        for(int j = 0; j < newArray.Length -1; j++)
        if (newArray[j] > newArray[j + 1])
        {
            int buff = newArray[j];
            newArray[j] = newArray[j + 1];
            newArray[j + 1] = buff;
        
        return newArray[j];
        Console.Write(newArray[j] + " ");
        }
    }
    
    
}
for (int i =0; i < newArray.Length; i++)
Console.Write(newArray[i] + " ");

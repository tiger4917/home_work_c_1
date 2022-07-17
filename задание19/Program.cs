/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int [,] array = new int [3,4];
int [] columnSums = new int [4];
for (int i =0; i < array.GetLength(0); i++)
{
    for (int j =0; j < array.GetLength(1); j++)
    {
        array[i,j]= new Random().Next(50);
        columnSums[j]+= array[i,j];
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
    for (int i=0; i < columnSums.Length; i++)
    {
    Console.WriteLine("Ср. арифм. колонки № " + i + "=" + (double)(columnSums[i])/array.GetLength(0));

    }   


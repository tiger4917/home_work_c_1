﻿//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[6];
int sum = 0;
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i] + " ");
    if (i % 2 == 0)
    {
        sum += array[i];
    }
}
Console.Write("]->" + sum);
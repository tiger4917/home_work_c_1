//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу,
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int[8];
int result = 0;
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write(array[i] + " ");
    if (array[i] % 2 == 0)
    {
        result += 1;
    }
}
Console.Write("] ->" +result);

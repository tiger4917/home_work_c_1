//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу,
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int[4];
int result = 0;
FillArray(array);
Result(array);
PrintArray(array);
Console.Write(result);
static void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
}
void Result(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        {
            result += 1;
        }
}




















/* static void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}
*/






/*int result = 0;
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
*/
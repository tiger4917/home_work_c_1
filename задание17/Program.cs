//: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
//  [3 7 22 2 78] -> 76
double[] array = new double[7];
double max=0;
double min=100;
double diff = 0;
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 90);
    Console.Write(array[i] + " ");
    if (array[i] > max)
    {
        max = array[i];
    }
     else if (array[i] < min)
    {
        min = array[i];
    }
}
diff = max - min;
Console.Write("] ->" + diff);
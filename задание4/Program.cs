Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
for (count =1; count < n; count ++)
{
     if (count % 2==0)
     {
          Console.Write($"{count} ,");
     }
}

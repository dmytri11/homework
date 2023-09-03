 //Задайте одномерный массив, заполненный случайными числами. 
 //Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
//Задайте одномерный массив, заполненный случайными числами. 
 //Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.WriteLine("Задайте размер массива");
int massiv =Convert.ToInt32(Console.ReadLine());
int[] array = new int [massiv];
int sum = 0;
int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    Console.WriteLine(String.Join(" ", array));
   return array;
}
int[] newarray = FillArray(array);
int SumElements(int[] newarray, int sum)
{

      for (int i = 1; i < newarray.Length; i +=2)
{
        sum = sum + newarray[i];
}
return sum;
}

int sum2=SumElements(newarray,sum);

Console.WriteLine($"Сумма элементов стоящих на нечётных позиция массива {sum2}");
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] array = new int[10];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine(String.Join(" ", array));
   
}
FillArray(array);
   int result = 0;
 void proverka(int[] array)
{
     for (int i = 0; i < array.Length; i++)
     {
          if (array[i] % 2 == 0)
          {
            result++;
            
          }
         
     }
      Console.WriteLine($"Количество четных элементов {result}");
 }
proverka(array);
 
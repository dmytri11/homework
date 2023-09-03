//: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double[] array = new double[8];
Random rand =  new Random();
for (int i = 0; i < array.Length; i++)
array[i] = Math.Round((rand.Next(-100, 100) + rand.NextDouble()), 2);
double max = array.Max();
double min = array.Min();
double raznica = max - min;
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Разница между максимальным и минимальным элементои {raznica}");

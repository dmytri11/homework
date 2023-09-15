//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
int[,] AddArray()
{
    Console.WriteLine("задайте параметры матрицы: ");
    int lengthArray = int.Parse(Console.ReadLine());
    int getArray = int.Parse(Console.ReadLine());
    int[,] array = new int[lengthArray,getArray];
    return array;
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void proizvod(int[,] array, int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($" {array[i, j] * array2[i, j]}");
        }
        Console.WriteLine();
    }
}
int[,] Multiplication(int[,] array, int[,] array2)
{
    if (array.GetLength(1) != array2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] r = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                r[i, j] += array[i, k] * array2[k, j];

            }
            Console.Write(r[i, j] + " ");
        }
        Console.WriteLine();
    }
    return r;
}
int[,] array = AddArray();
int[,] array2 = AddArray();
Console.WriteLine("--------");
FillArray(array);
Console.WriteLine("--------");
FillArray(array2);
Console.WriteLine("--------");
Console.WriteLine("Умножение элементов по индексам");
proizvod(array, array2);
Console.WriteLine("---------------");
Console.WriteLine("Умножение элементов по методу матриц(строка на столбик)");
Multiplication(array, array2);
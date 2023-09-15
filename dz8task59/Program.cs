//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
//на пересечении которых расположен наименьший элемент массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Наименьший элемент - 1, на выходе получим
//следующий массив:
//9 2 3
//4 2 4
//2 6 7

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
void MinElements(int[,] array,int MinEl,int minindexi,int minindexj)
{
    
    for (int i = 0; i <array.GetLength(0); i++)
        {
            for (int j = 0; j <array.GetLength(1) ; j++)
            {
                if (array[i, j] <= MinEl)
                    {
                        
                        minindexi = i;
                        minindexj = j;
                        MinEl = array[i, j];
                    }
            }
        }
       ;
}
////всё сломалось на этой функции всё сломалось времени нет буду завтра разбираться
///

int[,] array = AddArray();

Console.WriteLine("--------");
FillArray(array);
int minindexi = 0;
int minindexj = 0;
int MinEl = array[0, 0];
Console.WriteLine("--------");

Console.WriteLine($"{MinEl},{minindexi},{minindexj}");
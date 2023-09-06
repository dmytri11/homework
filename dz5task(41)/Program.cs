Console.WriteLine("Введите М чисел через запятую");
string valueStr = Console.ReadLine();
string[] values = valueStr.Split(",");
Console.Write("[");
Console.WriteLine(String.Join(", ", values));
Console.Write("]");
int result = 0;
void proverka(string[] values,int result)
{   
     for (int i = 0; i < values.Length; i++)
     {
          int a = Convert.ToInt32(values[i]);
          if (a > 0 )
          {
            result++;
          }
     }
      Console.WriteLine($"Количество четных элементов {result}");
}
 proverka(values, result);

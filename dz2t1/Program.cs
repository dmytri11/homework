// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Prompt(string message)
{

    System.Console.Write(message);
    string value = Console.ReadLine ();
    int resualt =Convert.ToInt32(value);
    return resualt;

}
int number = Prompt("Введите трёхзначное число > ");
if (number < 100 || number>= 1000)
{
    Console.WriteLine("Вы ввели не трёхзначное число, введите другое значнеие)");
     return;
}
Console.WriteLine($"Введённое число `{number}`");
int SecondRank= number  / 10 % 10;
Console.WriteLine($"Вторая цифра `{SecondRank}`" );
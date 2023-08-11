// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Prompt(string message)
{

    System.Console.Write(message);
    string value = Console.ReadLine ();
    int resualt =Convert.ToInt32(value);
    return resualt;

}
int GetThirdRank(int number)
{
while (number > 999)
{
number /= 10;
}
return number % 10;
}
bool ValidateNumber(int number)
{
if (number < 100)
{
    Console.WriteLine(«Третьей цифры нет»);
    return false;
}
 return true;
}
int number = Prompt("Введите число > ");
 int (ValidateNumber(number))
 {
    Console.WriteLine(GetThirdRank(number));
 }


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number > number2 ){
    Console.WriteLine("Первое число больше");
}
else {
    Console.WriteLine("Второе число больше");
}


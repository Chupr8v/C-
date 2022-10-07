// Выяснить является ли число чётным
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if(number % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
     Console.WriteLine("Число нечётное");
}


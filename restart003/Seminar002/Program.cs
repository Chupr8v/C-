//Console.WriteLine("Введите число");
//double b = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите x");
int x = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите y");
int y = int.Parse(Console.ReadLine() ?? "0");

if ((x > 0) && (y > 0))
{
    Console.Write("1-я четверть");
}

else if ((x > 0) && (y < 0))
{
    Console.Write("2-я четверть");
}

else if ((x < 0) && (y < 0))
{
    Console.Write("3-я четверть");
}

else if ((x < 0) && (y > 0))
{
    Console.Write("4-я четверть");
}


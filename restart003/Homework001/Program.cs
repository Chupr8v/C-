// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine() ?? "0");
if(a * a == b)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("No"); 
}
// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите число a: "); 
int a = int.Parse(Console.ReadLine() ?? "0"); 
Console.Write("Введите число b: "); 
int b = int.Parse(Console.ReadLine() ?? "0"); 
if(a * a == b)
{
    Console.WriteLine($"Число {b} является квадраьом числа {a}");
} 
else
{
    Console.WriteLine($"Число {b} не является квадраьом числа {a}");
} 
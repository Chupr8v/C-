// Найти максимальное из трех чисел
Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите c: ");
int c = int.Parse(Console.ReadLine() ?? "0");

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;


Console.Write("max = ");
Console.WriteLine(max);


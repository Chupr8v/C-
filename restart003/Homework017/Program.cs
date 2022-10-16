// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число n: "); 
double n = double.Parse(Console.ReadLine() ?? "0"); 
double a = 1;
for(double sum = 1; a<=n; a++)
{
    Console.Write($"{sum} * {a} = ");
    sum = sum * a;
    Console.WriteLine(sum);
}

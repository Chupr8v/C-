// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите число n: "); 
int n = int.Parse(Console.ReadLine() ?? "0"); 
int s = 1;
for(int a = 1; a<=n; a++)
{
    s=a*a*a;
    if(s % 2 == 0)
    {
        Console.WriteLine($"{a} в степени 3 = {s}");
    }    
}

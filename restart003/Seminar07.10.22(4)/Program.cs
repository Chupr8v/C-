// Определить количество цифр в числе
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine() ?? "0");
int count = 0;
if(a == 0000)
{
    Console.Writline("1");
}
else
{

    {
        while(a > 0)
        b = a % 10;
        count++;
    }
}    
Console.WriteLine(count);
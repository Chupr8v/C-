// Показать четные числа от 1 до N
Console.Write("Введите целое число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int number = 2;

while(number < n)
{
    if(number % 2 == 0)
    {
        Console.WriteLine(number);
    }
    number = number + 2;
}





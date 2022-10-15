// Показать таблицу квадратов чисел от 1 до N
int n = 100;
int i = 1;
int result = 0;
while (i <= n)
{
    result = i * i;
    Console.WriteLine( i + " = " + result);
    i++;
}

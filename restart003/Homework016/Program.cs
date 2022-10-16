// Подсчитать сумму цифр в числе
Console.Write("Введите число n: "); 
int n = int.Parse(Console.ReadLine() ?? "0"); 
string b = n.ToString();
int sum = 0;
for(int i = 0; i != b.Length; i++)
{
    sum = sum + (b[i] - '0');

}

Console.WriteLine($"Сумма чисел числа {n} = {sum}");
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = 7;
int c = 23;

if((a % c) + (a % b) == 0)
{
    Console.WriteLine (" Кратное  ");
} 
else
{
    Console.WriteLine (" Некратно ");
}



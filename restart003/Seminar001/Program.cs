Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = 7;
int c = 23;

if(a % c == 0)
{
    Console.WriteLine (" Кратное 7 ");
} 
else
{
    Console.WriteLine (" Некратно 7 ");
}

if(a % b == 0)
{
    Console.Writeline (" Кратное 23 ");
}

else
{
    Console.WriteLine (" Некратно 23 ");
}


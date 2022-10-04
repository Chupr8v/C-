Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine() ?? "0");
string b = a.ToString();
if(b[0] == b[4] && b[1] == b[3])
{
    Console.WriteLine("Палендром");
}
else
{
    Console.WriteLine("Не полендром");
}

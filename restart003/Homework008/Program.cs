// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Write("Введите число от 10 до 99: ");
int a = int.Parse(Console.ReadLine() ?? "0");
string b = a.ToString();

if(b[1] > b[0])
{   
    Console.Write("Наибольшая цифра: ");
    Console.WriteLine(b[1]);
}    
if(b[0] > b[1])
{
    Console.Write("Наибольшая цифра: ");
    Console.WriteLine(b[0]);
}    
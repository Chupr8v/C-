// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите номер дня недели: ");
string username = Console.ReadLine();

if(username.ToLower() == "1")
{
    Console.WriteLine("Понедельник");
}
if(username.ToLower() == "2")
{
    Console.WriteLine("Вторник");
}
if(username.ToLower() == "3")
{
    Console.WriteLine("Среда");
}
if(username.ToLower() == "4")
{
    Console.WriteLine("Четверг");
}
if(username.ToLower() == "5")
{
    Console.WriteLine("Пятница - улица развратница");
}
if(username.ToLower() == "6")
{
    Console.WriteLine("Суббота - выходной!");
}
if(username.ToLower() == "7")
{
    Console.WriteLine("Воскресенье - выходной!");
}



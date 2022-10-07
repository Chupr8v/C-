// По заданному номеру дня недели вывести его название

//{понедельник 1, вторник 2, среда 3, четверг 4, пятница 5, суббота 6, воскресенье 7};

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
    Console.WriteLine("Суббота");
}
if(username.ToLower() == "7")
{
    Console.WriteLine("Воскресенье");
}




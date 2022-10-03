Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "evlyv")
{
    Console.WriteLine("Привет, я люблю тебя, evlyv!!!");
}
else
{
    Console.Write("Привет, мой маленький ублюдок.");
    Console.Write(username);
}
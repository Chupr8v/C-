// Показать последнюю цифру трёхзначного числа
Console.Write("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
string b = a.ToString();
Console.Write("Третья цифра: ");
Console.WriteLine(b[2]);

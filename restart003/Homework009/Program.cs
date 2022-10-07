// Удалить вторую цифру трёхзначного числа
//H010 Выяснить, кратно ли число заданному, если нет, вывести остаток.
//H011 Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
string b = a.ToString();
Console.WriteLine(b);
Console.Write(b[0]);
Console.WriteLine(b[2]);

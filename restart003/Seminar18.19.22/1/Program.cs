// Выяснить являются ли три числа сторонами треугольника
/*
bool isTriangle(int a, int b, int c)//это просто функция
    return a > b + c || b > a + c || c > b + c;
*/

//Написать программу преобразования десятичного числа в двоичное

/*void decTobin(int dec)
{
    string
        res = "";

    while(dec > 0)
    {
        res = (dec % 2).ToString() + res;

        dec /= 2;
    }

    Console.WriteLine(res);
}

decTobin(7);*/

/*3. Найти точку пересечения двух прямых заданных уравнением 
y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
*/
Console.Write("k1 = ");
int k1 = int.Parse(Console.ReadLine() ?? "0"); 
Console.Write("k2 = ");
int k2 = int.Parse(Console.ReadLine() ?? "0"); 
Console.Write("b1 = ");
int b1 = int.Parse(Console.ReadLine() ?? "0"); 
Console.Write("b2 = ");
int b2 = int.Parse(Console.ReadLine() ?? "0"); 
if(k1 == k2)
    Console.WriteLine("Нет точек пересечения либо их бесконечно много!");
else
{
    int x = (b1-b2)/(k1-k2);
    int y = k1*x+b1;
    Console.WriteLine($"Точка пересечения с координатами: {x};{y}");
}

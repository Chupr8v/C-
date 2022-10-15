// Найти расстояние между точками в пространстве 2D/3D
/*
    x3 = x2 - x1;
    y3 = y2 - y1;
    z3 = z2 - z1;

    d = Math.Sqrt(x3 * x3 + y3 * y3 + z3 * z3);
*/

Console.Write("Введите координаты xa: "); 
int xa = int.Parse(Console.ReadLine() ?? "0"); 
Console.Write("Введите координаты ya: "); 
int ya = int.Parse(Console.ReadLine() ?? "0"); 
Console.Write("Введите координаты za: "); 
int za = int.Parse(Console.ReadLine() ?? "0"); 

Console.Write("Введите координаты xb: "); 
int xb = int.Parse(Console.ReadLine() ?? "0"); 
Console.Write("Введите координаты yb: "); 
int yb = int.Parse(Console.ReadLine() ?? "0"); 
Console.Write("Введите координаты zb: "); 
int zb = int.Parse(Console.ReadLine() ?? "0"); 

double d = Math.Sqrt((xb - xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
Console.WriteLine($"Расстояние между точкой a с координатами {xa};{ya};{za} и точкой b с координатами {xb};{yb};{zb} равно {d}.");



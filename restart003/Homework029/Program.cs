// Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");
Console.Write($"Введите число k: ");
int k = int.Parse(Console.ReadLine());

int xa = 10 * k; 
int ya = 1 * k;

int xb = 1 * k;
int yb = 8 * k;

int xc = 20 * k; 
int yc = 8 * k;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

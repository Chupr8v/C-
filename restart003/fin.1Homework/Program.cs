//Показать натуральные числа от M до N, N и M заданы
string NumbersRec(int m, int n)
{
    if(m<=n) return $"{m} " + NumbersRec(m+1, n);
    else return String.Empty;
}
Console.WriteLine(NumbersRec(1, 10));         // (a+b)*(b-a+1)/2
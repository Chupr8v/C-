﻿// Написать программу возведения числа А в целую стень B
int PowerRec(int a, int n)
{
    if(n==0) return 1;
    else return PowerRec(a, n-1) *a;
}
Console.WriteLine(PowerRec(2,5));
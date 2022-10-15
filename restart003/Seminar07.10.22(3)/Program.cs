//Возведите число А в натуральную степень B используя цикл
int n = 120;
int i = 3;
int result = 1;
int count = 1;
while (i < n)
{
    result = result * i;
    Console.WriteLine(result);
    i = i * 3;
   
}



// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем
Console.WriteLine("До какого числа считать ряд Фибоначчи?");
int number = Convert.ToInt32(Console.ReadLine());
int perv = 1;
Console.Write("{0} ", perv);
int vtor = 2;
Console.Write("{0} ", vtor);
int sum = 0;

while (number >= sum)
            {
                sum = perv + vtor;
                
                    Console.Write("{0} ", sum);
                    {
                        perv = vtor;
                        vtor = sum;                
                    }            
            }
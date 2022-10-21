// // I. Реализовать следующие функции для работы с массивами:
// 1. Поиск минимума // 2. Поиск максимума
void MinMax(int[] array)
{
    int max = 0;
    int min = 999;
    for(int index = 0; index < array.Length; index++)
    { 
        if(array[index] > max)
        {
            max = array[index];
        }
        else if(array[index] < min) 
        {
            min = array[index];
        }

      
    }        
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
}   
// 3. Поиск суммы элементов массива
int SumArray(int[] array)
{
    int sum = 0;
    for(int index = 0; index < array.Length; index++)
        sum=sum+array[index];
    return(sum);
}
// 4. Поиск произведения элементов массива
void UmnArray(int[] array)
{
    int sum = 0;
    for(int index = 0; index < array.Length; index++)
        sum=sum*array[index];
    Console.WriteLine(sum);
}
// 5. Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
int Count(int[] array, int value)
{
    for (int index = 0; index < array.Length; index++)
        if(array[index] == value)
            return index;
    return -1;
}
// 6. Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет.
bool CountTF(int[] array, int value)
{
    for (int index = 0; index < array.Length; index++)
        if(array[index] == value)
            return true;
    return false;
}
// 7. Печать массива на экран
void PrintArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
         Console.Write($"{array[index]} ");

    Console.WriteLine();
}
// 8. Среднее арифметическое элеметов массива
float ArifSr(int[] array)
    {
        return SumArray(array)/array.Length;
    }
// 9. Подсчёт количества отрицательных элементов массива
int CountNegEl(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            count++;
    }
    return count;
}
// 10. Подсчёт количества вхождений элемента в массив
int CountKolvo(int[] array, int value)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
        if(array[index] == value)
            count++;
    return count;
}
// 11. Подсчёт количества чётных элементов в массив // 13. Подсчёт количества нечётных элементов в массиве
void CountChNch(int[] array, int countch, int countnch)
{
    for(int index = 0; index < array.Length; index++)
    { 
        if(array[index] % 2 == 0)
        {
            countch++;
        }    
        
        else if(array[index] % 2 == 1)
        {
            countnch++;
        }    
        
    }        
    Console.WriteLine($"Количество чётных чисел в массиве: {countch}");
    Console.WriteLine($"Количество нечётных чисел в массиве: {countnch}");
}
// 12. Подсчёт количества положительных элементов в массиве
int CountPosEl(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            count++;
    }
    return count;
}
// 14. Проверка является ли массив отсортированным по возрастанию. Если массив отсортирован, то возвращать true, иначе - false.
bool IsSorted(int[] array)
{
    int count = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i-1] > array[i])
            return false;
    }
    return true;
}
// II. Реализовать следующие функции:
// 1. Функцию, которая вычисляет число a в степени n
int Pow(int a, int n)
{
    for(int i = 0; i < n; i++)
        a *= a;
    return a;
}
// 2. Функцию, которая вычисляет факториал числа n
int Fact(int a)
{
    if(a == 1)
        return a;
    else
        return a * Fact(a - 1);
}
// 3. Функцию, которая вычисляет сумму цифр произвольного целого числа n
int SumNums(int n)
{
    int sum = 0;
    string num = n.ToString();
    for(int i = 0; i < num.Length; i++)
    {
        sum += num[i] - '0';
    }
    return sum;
}
// 4. Функцию, которая проверяет является ли заданное число n полиндромом
bool Palendrom(int a)
{
    string b = a.ToString();
    int size = b.Length;
    if (size % 2 == 1)
        size--;
    for(int count = 0; count <= size/2; count++)
    {
        if(b[count] != b[size - count - 1])
            return false;
    }
    return true;
}    
// 5. Функцию, складывающую два целых числа
int Sum(int a, int b)
{
    return a + b;
}
// 6. Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false

// 7. Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false
bool ChNum(int a)
{
    if(a % 2 == 0)
        return true;
    else
        return false;
}
// III. Вызвать и проверить работу всех вышеуказанных фукнций
void FillArray(int[] array, int min, int max)
{
    for(int index = 0; index < array.Length; index++)
        array[index] = new Random().Next(min, max); 

}

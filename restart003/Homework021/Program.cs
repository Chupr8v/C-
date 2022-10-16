// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void PrintArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
         Console.Write($"{array[index]} ");

    Console.WriteLine();
}

void FillArray(int[] array, int min, int max)
{
    for(int index = 0; index < array.Length; index++)
        array[index] = new Random().Next(min, max); 

}

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

Console.Write("Enter size of array: "); 
int size = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = new int[size];

FillArray(array, 100, 999);
Console.Write("Your array: ");
PrintArray(array);

int count1 =0;
int count2 =0;
CountChNch(array, count1, count2);


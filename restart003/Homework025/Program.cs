// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
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

Console.Write("Enter size of array: "); 
int size = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = new int[size];

FillArray(array, 0, 999);
Console.Write("Your array: ");
PrintArray(array);
MinMax(array);
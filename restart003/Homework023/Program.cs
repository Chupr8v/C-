// Найти сумму чисел одномерного массива стоящих на нечетной позиции
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
void SumArray(int[] array)
{
    int sum = 0;
    for(int index = 0; index < array.Length; index++)
    { 
       
        if(index % 2 == 1)
        {
            sum = sum + index;
        }    
        
      
    }        
    Console.WriteLine($"Сумма чисел индексов нечётных позиций: {sum}");
}   

Console.Write("Enter size of array: "); 
int size = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = new int[size];

FillArray(array, 100, 999);
Console.Write("Your array: ");
PrintArray(array);
SumArray(array);
// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
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
void Search(int[] array)//Функция которая находит числа из отрезка [10, 99].
{
    int count = 0;
    for(int index = 0; index < array.Length; index++)
    { 
        if(array[index]>=10 && array[index]<=99)
        {
            count++;
        }    
    
    }        
    Console.WriteLine($"Количество чисел из отрезка [10, 99] в массиве: {count}");
   
}

int size = 123;
int[] array = new int[size];

FillArray(array, 0, 123);
Console.Write("Your array: ");
PrintArray(array);
Search(array);
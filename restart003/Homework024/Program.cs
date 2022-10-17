// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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
    int multi;   
    for(int index = 0, size = array.Length; index < size / 2; index++)
    { 
        multi =  array[index] * array[size - index - 1];
        Console.WriteLine($"Произведение [{index}] и [{size - index - 1}] = {multi}");
    }

}
Console.Write("Enter size of array: "); 
int size = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = new int[size];

FillArray(array, 1, 999);
Console.Write("Your array: ");
PrintArray(array);
SumArray(array);
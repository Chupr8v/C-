// Написать программу копирования массива
void FillArray(int[] array, int min, int max)
{
    for(int index = 0; index < array.Length; index++)
        array[index] = new Random().Next(min, max); 

}
void PrintArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
         Console.Write($"{array[index]} ");

    Console.WriteLine();
}


Console.Write("Enter size of array: "); 
int size = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = new int[size];
FillArray(array, 1, 12);
Console.Write("Your array: ");
PrintArray(array);
Console.Write("Copy array: ");
PrintArray(array);
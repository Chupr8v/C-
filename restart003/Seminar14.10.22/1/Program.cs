// Сколько раз число встретиться в массиве
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

int Count(int[] array, int value)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
        if(array[index] == value)
            count++;
    return count;
}


Console.Write("Enter size of array: "); 
int size = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = new int[size];

FillArray(array, 0, 15);
Console.Write("Your array: ");
PrintArray(array);

Console.Write("Введите число: "); 
int value = int.Parse(Console.ReadLine() ?? "0"); 
int count = Count(array, value);

Console.WriteLine($"заданное число {value} встречается в количестве {count}");
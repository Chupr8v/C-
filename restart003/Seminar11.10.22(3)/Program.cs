// Определить, присутствует ли в заданном массиве, некоторое число
Console.Write("Enter size of array: "); 
int length = int.Parse(Console.ReadLine() ?? "0"); 
Console.Write("Введите число: "); 
int n = int.Parse(Console.ReadLine() ?? "0"); 
bool x = false;
int[] array = new int[length];
Console.Write("Your array: ");  
for(int i=0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,10); 
    Console.Write($"{array[i]} ");
}    
for(int i=0; i < array.Length; i++)
{
    if(array[i] == n)
    {
        x = true;
    }
    else (x = false)
}



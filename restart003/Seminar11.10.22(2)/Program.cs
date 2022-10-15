// Написать программу замену элементов массива на противоположные
Console.Write("Enter size of array: "); 
int length = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = new int[length]; 
for(int i=0;i<array. Length;i++)
{
    array[i] = new Random().Next(-10,10); 
    Console.Write("Your array: "); 
}
for(int i=0;i<array. Length;i++)

{
     Console.Write($"{array[i]} ");
     Console.WriteLine(); 
}     
 for(int i=0;i<array. Length;i++)
 {
    array[i] = -array[i]; 
    Console.Write("Your changed array: "); 
 }   
for(int i=0;i<array. Length;i++)
{ 
    Console.Write($"{array[i]} ");
}

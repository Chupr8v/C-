﻿// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
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
        sum=sum+array[index];
    Console.WriteLine(sum);
}


int size = 12; 
int[] array = new int[size];
FillArray(array, 0, 9);
Console.Write("Your array: ");
PrintArray(array);
SumArray(array);


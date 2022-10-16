﻿/*
Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Найти сумму чисел одномерного массива стоящих на нечетной позиции
Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
*/
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


int size = 8; 
int[] array = new int[size];
FillArray(array, 0, 1);
Console.Write("Your array: ");
PrintArray(array);
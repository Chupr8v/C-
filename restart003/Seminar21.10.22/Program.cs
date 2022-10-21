// 1. Показать двумерный массив размером m×n заполненный целыми числами
//2. В двумерном массиве n×k заменить четные элементы на противоположные
/*void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j =0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j =0; j<matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
            if(matr[i,j] % 2 == 0)
                matr[i,j] = -matr[i,j];
        }
    }
}

*/


//В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j =0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j =0; j<matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
void VLArray(int[,] matr, int value)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j =0; j<matr.GetLength(1); j++)
        {
             if(matr[i,j]  == value)
             { 
                Console.WriteLine($"Это число находится на строке {i} и в столбце {j}.");
                return;
             }    
                 
        
        }
    }
    Console.WriteLine($"No number"); 
}



int[,] matrix = new int[3, 5];
FillArray(matrix);
PrintArray(matrix);

VLArray(matrix, 9);

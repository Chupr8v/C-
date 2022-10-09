// 4
//string Method4(int count, string c);
//{
    //int i = 0;
   // string result = string.Empty;
   //  while (i < count)
   //  {
   //     result = result + text;
    //    i++;
    // }
     //return result;
//}
//string res = Method4(10, "Hello");

//

int[] arr = {1, 5, 4, 3, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
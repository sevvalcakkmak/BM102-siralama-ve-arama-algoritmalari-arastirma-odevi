using System;

class BubbleSort
{
    static void Main(string[] args)
    {
        int[] array = { 9, 7, 2, 4, 3, 5, 6, 8, 1, 0 };
        Console.WriteLine("Unsorted array:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine("\n");

        bubbleSort(array);

        Console.WriteLine("Sorted array:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }

    private static void bubbleSort(int[] arr)
    {
        int size = arr.Length;
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = 0; j < size - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {  
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
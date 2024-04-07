using System;

class InsertionSort
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

        insertionSort(array);
        
        Console.WriteLine("Sorted array:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }

    private static void insertionSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int temp = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > temp)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = temp;
        }
    }
}
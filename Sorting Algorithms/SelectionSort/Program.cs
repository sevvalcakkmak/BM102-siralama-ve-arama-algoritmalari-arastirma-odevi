using System;

class SelectionSort
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

        selectionSort(array);

        Console.WriteLine("Sorted array:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }

    private static void selectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[min] > array[j])
                {
                    min = j;
                }

            }
            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
    }
}
using System;

class LinearSearch
{
    static void Main(string[] args)
    {
        int[] array = {9, 7, 2, 4, 3, 5, 6, 8, 1, 0};
        int element = 1;
        int index = linearSearch(array, element);

        if (index != -1)
        {
            Console.WriteLine("Element found at index: {0}", index);
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }

    private static int linearSearch(int[] array, int element)
    {
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
                return i;
        }
        return -1;
    }
}
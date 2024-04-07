using System;

class BinarySearch
{
    static void Main(string[] args)
    {
        int[] array = new int[100000];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }
        int element = 2346;

        int index = binarySearch(array, element);
        if (index != -1)
        {
            Console.WriteLine("Element found at index: {0}", index);
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }

    private static int binarySearch(int[] array, int element)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int middle = (low + high) / 2;
            int value = array[middle];

            Console.WriteLine("Middle: {0}", value);

            if (value < element)
            {
                low = middle + 1;
            }

            else if (value > element)
            {
                high = middle - 1;
            }
            else
            {
                return middle;
            }
        }
        return -1;
    }
}
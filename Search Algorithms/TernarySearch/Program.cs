using System;

class TernarySearch
{
    static void Main(string[] args)
    {
        int left, right, index, element;

        int[] array = new int[100000];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }

        left = 0;
        right = array.Length;
        element = 2346;

        index = ternarySearch(array, left, right, element);

        if (index != -1)
        {
            Console.WriteLine("Element found at index: {0}", index);
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }

    private static int ternarySearch(int[] array, int left, int right, int element)
    {
        if (left <= right)
        {
            int mid1 = left + (right - left) / 3;
            int mid2 = right - (right - left) / 3;

            if (array[mid1] == element)
            {
                return mid1;
            }
            if (array[mid2] == element)
            {
                return mid2;
            }

            if (element < array[mid1])
            {
                return ternarySearch(array, left, mid1 - 1, element);
            }
            else if (element > array[mid2])
            {
                return ternarySearch(array, mid2 + 1, right, element);
            }
            else
            {
                return ternarySearch(array, mid1 + 1, mid2 - 1, element);
            }
        }
        return -1;
    }
}
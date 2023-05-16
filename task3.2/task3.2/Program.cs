using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[30] { 5, 2, 9, 7, 1, 8, 3, 6, 4, 10, 14, 11, 12, 13, 15, 20, 17, 19, 16, 18, 21, 23, 22, 26, 25, 28, 24, 29, 27, 30 };

        Console.WriteLine("Unsorted array:");
        PrintArray(arr);

        // bubble sort
        BubbleSort(arr);
        Console.WriteLine("\nArray sorted with bubble sort:");
        PrintArray(arr);

        // selection sort
        arr = new int[30] { 5, 2, 9, 7, 1, 8, 3, 6, 4, 10, 14, 11, 12, 13, 15, 20, 17, 19, 16, 18, 21, 23, 22, 26, 25, 28, 24, 29, 27, 30 };
        SelectionSort(arr);
        Console.WriteLine("\nArray sorted with selection sort:");
        PrintArray(arr);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
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

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
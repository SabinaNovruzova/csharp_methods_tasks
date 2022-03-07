using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 15, 30, 55, 75, 4 };
            Min(arr);
            Console.WriteLine(Min(arr));
        }
        static int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}

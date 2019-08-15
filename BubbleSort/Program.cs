using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] { 2, 1, 8, 4, 3, 14, 12, 45, 48 };
            Display(BubbleSortMethod(unsortedArray));

            // bubble sort  
            Console.ReadLine();
        }
        public static int[] BubbleSortMethod(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; (i <= (n - 1)); i++)
            {

                for (int j = 0; j < (n - 1); j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }
            }
            return arr;
        }
        //Utility/helper method 
        public static void Display(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num.ToString() + " ");
            }
        }
    }
}

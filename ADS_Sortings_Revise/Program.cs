using System;

namespace ADS_Sortings_Revise
{
    class Program
    {
        static int Min(int[] Array)
        {
            int min = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (min > Array[i])
                {
                    min = Array[i];
                }
            }
            return min;
        }
        
        static int Max(int[] Array)
        {
            int max = Array[0];
            for (int j = 0; j < Array.Length; j++)
            {
                if (max < Array[j])
                {
                    max = Array[j];
                }
            }
            return max;
        }


        static void Main(string[] args)
        {
            // Bubble Sort
            int[] bubble = new int[] { 4, 5, 1, -2, -3 };

            for (int i = 0; i < bubble.Length - 1; i++)
            {
                for (int j = 0; j < bubble.Length - 1; j++)
                {
                    if (bubble[j] > bubble[j + 1])
                    {
                        int temp = bubble[j];
                        bubble[j] = bubble[j + 1];
                        bubble[j + 1] = temp;
                    }
                }
            }

            Console.Write("Bubble Sort: \n => ");
            foreach (int el in bubble)
            {
                Console.Write(el + " ");
            }


            // Insertion Sort
            int[] insertion = new int[] { 4, 5, 1, -2, -3 };

            for (int i = 0; i < insertion.Length; i++)
            {
                int value = insertion[i];
                int index = i;

                while (index > 0 && insertion[index - 1] >= value)
                {
                    insertion[index] = insertion[index - 1];
                    index--;
                }
                insertion[index] = value;

            }

            Console.WriteLine();
            Console.Write("Insertion Sort: \n => ");
            foreach (int el in insertion)
            {
                Console.Write(el + " ");
            }


            // Selection Sort
            int[] selection = new int[] { 4, 5, 1, -2, -3 };

            int tempS, smallest;

            for (int i = 0; i < selection.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < selection.Length; j++)
                {
                    if (selection[j] < selection[smallest])
                    {
                        smallest = j;
                    }
                }
                tempS = selection[smallest];
                selection[smallest] = selection[i];
                selection[i] = tempS;
            }

            Console.WriteLine();
            Console.Write("Selection Sort: \n => ");
            foreach (int el in selection)
            {
                Console.Write(el + " ");
            }


            // Counting Sort
            int[] collection = new int[] { 4, 5, 1, -2, -3 };
            int[] sorted = new int[collection.Length];
            int minVal = Min(collection);
            int maxVal = Max(collection);
            int[] counter = new int[maxVal - minVal + 1];

            for (int a = 0; a < collection.Length; a++)
            {
                counter[collection[a] - minVal]++;
            }
            counter[0]--;

            for (int b = 1; b < counter.Length; b++)
            {
                counter[b] += counter[b - 1];
            }

            for (int c = collection.Length - 1; c >= 0; c--)
            {
                sorted[counter[collection[c] - minVal]--] = collection[c];
            }

            Console.WriteLine();
            Console.Write("Counting Sort: \n => ");
            foreach (int el in sorted)
            {
                Console.Write(el + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Swap(ref int x, ref int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
        }
        static void ShowArray(int[] array)
        {
            foreach(int a in array)
                Console.Write(a + " ");
            Console.WriteLine();
        }
        //Sorthing algorithms
        static void BubbleSort(int[] array)
        {
            int i, j;
            bool b;
            for(i = 0; i < array.Length - 1; i++)
            {
                b = false;
                for(j = 0; j < array.Length - 1; j++)
                    if(array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        b = true;
                    }
                if (b == false)
                    break;
            }
            Console.Write("Bubble Sort: ");
            ShowArray(array);
        }
        static void SelectionSort(int[] array)
        {
            int i, j;
            for(i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (j = i + 1; j < array.Length; j++)
                    if (array[j] < array[minIndex])
                        minIndex = j;
                if (minIndex > i)
                    Swap(ref array[minIndex], ref array[i]);              
            }
            Console.Write("Selection Sort: ");
            ShowArray(array);
        }
        static void InsertionSort(int[] array)
        {
            int i, j;
            for (i = 1; i < array.Length; i++)
                for (j = i; j > 0; j--)
                    if (array[j - 1] > array[j])
                        Swap(ref array[j - 1], ref array[j]);
            Console.Write("Insertion Sort: ");
            ShowArray(array);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");           
            int n;
            do
            {
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            int[] array = new int[n];
            Random rd = new Random();
            int i;
            for (i = 0; i < array.Length; i++)
                array[i] = rd.Next(-99, 100);
            Console.Write("Array is: ");
            ShowArray(array);
            Console.WriteLine();

            //1. Bubble Sort Algorithm
            BubbleSort(array);
            Console.WriteLine();

            //2. Selection Sort Algorithm
            SelectionSort(array);
            Console.WriteLine();

            //3. Insertion Sort Algorithm
            InsertionSort(array);
            Console.WriteLine();
        }
    }
}

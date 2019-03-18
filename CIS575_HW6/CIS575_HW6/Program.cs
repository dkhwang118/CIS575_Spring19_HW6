using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS575_HW6
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Main Run Begin
            int[] PRI_array100 = GenerateRndArray(100);
            int[] PRI_array1k = GenerateRndArray(1000);
            int[] PRI_array10k = GenerateRndArray(10000);
            int[] AOI_array100 = GenerateAlmstOrderedArray(100);
            int[] AOI_array1k = GenerateAlmstOrderedArray(1000);
            int[] AOI_array10k = GenerateAlmstOrderedArray(10000);

            Console.WriteLine("PRI_100 = {0} swaps", InsertionSort(PRI_array100));
            Console.WriteLine("PRI_1k = {0} swaps", InsertionSort(PRI_array1k));
            Console.WriteLine("PRI_10k = {0} swaps", InsertionSort(PRI_array10k));
            Console.WriteLine("AOI_100 = {0} swaps", InsertionSort(AOI_array100));
            Console.WriteLine("AOI_1k = {0} swaps", InsertionSort(AOI_array1k));
            Console.WriteLine("AOI_10k = {0} swaps", InsertionSort(AOI_array10k));

            Console.ReadLine();



            /// InsetionSort; Returns number of swaps performed on array
            int InsertionSort(int[] arr)
            {
                int numOfSwaps = 0;
                for (int i = 0; i < (arr.Length); i++)
                {
                    int j = i;
                    while (j > 0 && (arr[j] < arr[j - 1]))
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                        numOfSwaps++;
                        j--;
                    }
                }
                return numOfSwaps;
            }

            /// Generates a pseduo-random array of size size;
            int[] GenerateRndArray(int size)
            {
                int[] returnArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    returnArray[i] = (13 * i) % size;
                }
                return returnArray;
            }


            int[] GenerateAlmstOrderedArray(int size)
            {
                int[] returnArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    if (i % 13 != 12)
                    {
                        returnArray[i] = i;
                    }
                    else
                    {
                        returnArray[i] = (i + 13) % size;
                    }                
                }
                return returnArray;
            }
        }
    }
}

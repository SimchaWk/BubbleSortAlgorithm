using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortAlgorithm
{
    internal class BubbleSortAlgo
    {
        public static int[] BubbleSort(int[] arr)
        {
            bool unSorted = true;
            int tempLength = arr.Length - 1;

            while (unSorted)
            {
                unSorted = false;
                for (int i = 0; i < tempLength; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                        unSorted = true;
                    }
                }
                tempLength--;
            }
            return arr;
        }
    }
}

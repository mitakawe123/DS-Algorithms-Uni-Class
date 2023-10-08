using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Uni_Class.Sorting_Algorithms
{
    public static class SelectionSort
    {
        // най лошия случай е O(N^2)
        // работи на принципа че ще обиколи целия масив ще намери най малкото число и ще го постави на неговото място
        public static void DKSelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length - 1; j++)
                    if (arr[j] < arr[min])
                        min = j;

                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
    }
}

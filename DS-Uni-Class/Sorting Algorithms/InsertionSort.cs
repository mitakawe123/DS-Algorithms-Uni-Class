using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Uni_Class.Sorting_Algorithms
{
    public class InsertionSort
    {
        public static void DKInsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j+1] = temp;
            }
        }
    }
}

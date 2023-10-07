using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Uni_Class.Sorting_Algorithms
{
    public class QuickSort
    {
        public static void DKQuickSort(int[] arr, int start, int end)
        {
            if (end <= start) return;

            int pivot = Partition(arr, start, end);
            DKQuickSort(arr, start, pivot - 1);
            DKQuickSort(arr, pivot + 1, end);
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start - 1;
            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] >= pivot) continue;
                //here you can use Tuple to switch variables too
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            i++;
            int temp1 = arr[i];
            arr[i] = arr[end];
            arr[end] = temp1;

            return i;
        }
    }
}

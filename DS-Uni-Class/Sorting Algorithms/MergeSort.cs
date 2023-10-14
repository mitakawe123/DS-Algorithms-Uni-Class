using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Uni_Class.Sorting_Algorithms
{
    public class MergeSort
    {
        //най лошият случай е O(n log n)
        //divide and conquer algorithm
        //Алгоритъмът на сливането (merge sort) разделя масива на две половини.
        //Всеки отделен подмасив се сортира независимо.
        //След това се сливат по двойки, като се подреждат в правилния ред.
        //Този процес се повтаря, докато масивът стане напълно сортиран.
        public static void DKMergeSort(int[] arr)
        {
            int length = arr.Length;
            if (length <= 1) return;

            int middle = length / 2;
            int[] leftArr = new int[middle];
            int[] rightArr = new int[length - middle];

            int i = 0, j = 0;
            for (; i < length; i++)
            {
                if (i < middle)
                {
                    leftArr[i] = arr[i];
                }
                else
                {
                    rightArr[j] = arr[i];
                    j++;
                }
            }
            DKMergeSort(leftArr);
            DKMergeSort(rightArr);
            Merge(leftArr, rightArr, arr);
        }

        private static void Merge(int[] leftArr, int[] rightArr, int[] arr)
        {
            int leftSize = arr.Length / 2;
            int rightSize = arr.Length - leftSize;
            int i = 0, left = 0, right = 0;
            while (left < leftSize && right < rightSize)
            {
                if (leftArr[left] < rightArr[right])
                {
                    arr[i] = leftArr[left];
                    left++;
                    i++;
                }
                else
                {
                    arr[i] = rightArr[right];
                    right++;
                    i++;
                }
            }

            while (left < leftSize)
            {
                arr[i] = leftArr[left];
                left++;
                i++;
            }

            while (right < rightSize)
            {
                arr[i] = rightArr[right];
                right++; 
                i++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Uni_Class.Sorting_Algorithms
{
    public class QuickSort
    {
        //най лошия случай при този алгоритъм е O(N^2)
        //дадения пример работи на принципа че взимаме най крайното число в масива и се опитавме да го сложим на "центъра на масива"
        //след като стане това имаме лява и дясна част на масива които ще започнем да сортираме чрез рекурсия
        //можем да разберем дали имаме "център на масива" като погледнем дали всички числа преди него са по малки и всички числа след него са по големи
        //чрез рекурсията ще вземем двете страни преди и след "центъра на масива"
        //ще започнем да намираме други "центъри на масива" като ги разделяме на части и разменяме чрез трета променлива местата на числата
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

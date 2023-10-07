using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Uni_Class
{
    public static class BinarySearch
    {
        //най лошия случай на този алгоритъм е O(log n)
        //работи на принципа че започваме от средата
        //правим постояни проверки дали сме намерили нашия елемент като делим масива на половина
        //пример за това ако имате масив [1,2,3,4,5] и търсите елемент 5
        //ще започнете от числото 3  и ще проверите дали това е вашето число
        //не е вашето число следователно разделяте масива на половина и взимате дясната страна и местите mid променливата на числото 4
        //виждаме че вислото 4 не отговаря на нашето търсене следователно пак делим масива на половина и местим променливата mid на числото 5
        //след като сме преместили mid на числото 5 връщаме индекса на намереното число

        public static int DKBinarySearch(int[] arr, int target)
        {
            int start = 0, end = arr.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] == target)
                    return mid;

                if (arr[mid] < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }

            return -1;
        }
    }
}

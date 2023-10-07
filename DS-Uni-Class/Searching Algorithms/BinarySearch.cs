using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Uni_Class
{
    public static class BinarySearch
    {
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

using System.Collections.Concurrent;
using DS_Uni_Class.Sorting_Algorithms;

namespace DS_Uni_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 5, 3, 10, 2 };
            MergeSort.DKMergeSort(arr);
        }

        private static void QS(int[] arr, int start, int end)
        {
        }
    }
}
using DS_Uni_Class.Sorting_Algorithms;

namespace DS_Uni_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 5, 3, 10, 2 };
            QuickSort.DKQuickSort(arr, 0, arr.Length - 1);
            var b = 3;
        }
    }
}
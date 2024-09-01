using static BubbleSortAlgorithm.BubbleSortAlgo;

namespace BubbleSortAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 8, 3, 2, 6, 5, 4, 3, };
            Console.WriteLine(string.Join(", ", nums));


            Console.WriteLine(string.Join(", ", BubbleSort(nums)));
        }
    }
}

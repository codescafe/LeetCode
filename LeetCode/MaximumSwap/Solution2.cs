namespace LeetCode.MaximumSwap
{
    public class Solution2 : ISolution
    {
        /// <summary>
        /// Greedy - O(n)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int MaximumSwap(int num)
        {
            var arr = num.ToString().ToCharArray();
            int maxIndex = arr.Length - 1;
            int leftIndex = -1;
            int rightIndex = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
                else if (arr[i] < arr[maxIndex])
                {
                    leftIndex = i;
                    rightIndex = maxIndex;
                }
            }
            if (leftIndex >= 0)
            {
                char temp = arr[leftIndex];
                arr[leftIndex] = arr[rightIndex];
                arr[rightIndex] = temp;
            }
            return Convert.ToInt32(new string(arr));
        }
    }
}

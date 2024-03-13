namespace LeetCode.MaximumSwap
{
    public class Solution1 : ISolution
    {
        /// <summary>
        /// O(n^2)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int MaximumSwap(int num)
        {
            var arr = num.ToString().ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '9')
                {
                    continue;
                }
                bool swap = false;
                char maxChar = arr[i];
                int maxCharIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > maxChar || (arr[j] == maxChar && swap == true))
                    {
                        maxChar = arr[j];
                        maxCharIndex = j;
                        swap = true;
                    }
                }
                if (swap)
                {
                    char temp = arr[i];
                    arr[i] = maxChar;
                    arr[maxCharIndex] = temp;
                    break;
                }
            }

            return Convert.ToInt32(new string(arr));
        }
    }
}

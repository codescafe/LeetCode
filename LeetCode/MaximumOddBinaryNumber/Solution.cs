namespace LeetCode.MaximumOddBinaryNumber
{
    public class Solution : ISolution
    {
        public string MaximumOddBinaryNumber(string s)
        {
            var oneCount = s.Count(c => c == '1');
            var zeroCount = s.Count(c => c == '0');
            return new string('1', oneCount - 1) + new string('0', zeroCount) + "1";
        }
    }
}

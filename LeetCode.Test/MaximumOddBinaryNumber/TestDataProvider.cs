using LeetCode.MaximumOddBinaryNumber;

namespace LeetCode.Test.MaximumOddBinaryNumber
{
    public class TestDataProvider
    {
        public static IEnumerable<object[]> GetSolutions()
        {
            yield return new object[] { new Solution(), "010", "001" };
            yield return new object[] { new Solution(), "0101", "1001" };
        }
    }
}
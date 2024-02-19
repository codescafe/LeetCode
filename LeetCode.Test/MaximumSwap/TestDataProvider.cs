using LeetCode.MaximumSwap;

namespace LeetCode.Test.MaximumSwap
{
    public class TestDataProvider
    {
        public static IEnumerable<object[]> GetSolutions()
        {
            yield return new object[] { new Solution1(), 2736, 7236 };
            yield return new object[] { new Solution1(), 9973, 9973 };
            yield return new object[] { new Solution1(), 1993, 9913 };
            yield return new object[] { new Solution1(), 98368, 98863 };
            yield return new object[] { new Solution2(), 2736, 7236 };
            yield return new object[] { new Solution2(), 9973, 9973 };
            yield return new object[] { new Solution2(), 1993, 9913 };
            yield return new object[] { new Solution2(), 98368, 98863 };
        }
    }
}
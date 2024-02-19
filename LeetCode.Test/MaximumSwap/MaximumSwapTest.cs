using LeetCode.MaximumSwap;

namespace LeetCode.Test.MaximumSwap
{
    public class MaximumSwapTest
    {

        [Theory]
        [MemberData(nameof(TestDataProvider.GetSolutions), MemberType = typeof(TestDataProvider))]
        public void Test(ISolution solution, int input, int expected)
        {
            var actual = solution.MaximumSwap(input);
            Assert.Equal(expected, actual);
        }
    }
}
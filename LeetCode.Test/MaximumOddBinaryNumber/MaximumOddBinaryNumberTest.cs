using LeetCode.MaximumOddBinaryNumber;

namespace LeetCode.Test.MaximumOddBinaryNumber
{
    public class MaximumOddBinaryNumberTest
    {

        [Theory]
        [MemberData(nameof(TestDataProvider.GetSolutions), MemberType = typeof(TestDataProvider))]
        public void Test(ISolution solution, string input, string expected)
        {
            var actual = solution.MaximumOddBinaryNumber(input);
            Assert.Equal(expected, actual);
        }
    }
}
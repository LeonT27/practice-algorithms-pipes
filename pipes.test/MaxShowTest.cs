using FluentAssertions;
using Xunit;
using pipes.console;

namespace pipes.test
{
    public class MaxShowTest
    {
        [Theory]
        [InlineData(30, 5, 10, new[] { 7, 7, 8, 9, 9 })]
        [InlineData(293, 10, 73, new[] { 70, 19, 42, 22, 59, 10, 80, 32, 7, 29 })]
        [InlineData(59, 10, 38, new[] { 29, 64, 89, 96, 16, 40, 58, 27, 59, 32 })]
        [InlineData(414, 10, 153, new[] { 89, 17, 32, 92, 5, 22, 30, 26, 51, 24 })]
        [InlineData(378, 10, 101, new[] { 79, 72, 22, 78, 44, 66, 56, 29, 59, 66 })]
        [InlineData(521, 10, 162, new[] { 14, 29, 14, 5, 34, 65, 53, 28, 4, 64 })]
        public void Calculate_Cost_Of_Operation(int expectedValue, int n, int h, int[] a)
        {
            var maxShows = Program.MaxShows(n, h, a);
            maxShows.Should().Be(expectedValue);
        }
    }
}

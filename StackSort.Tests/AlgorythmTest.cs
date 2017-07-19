using Xunit;

namespace StackSort.Tests
{
    public class AlgorythmTest
    {
        [Fact]
        public void WhenInputNotSorted_ReturnsSorted()
        {
            int[] input = { 1, 3, 5, 4, 7, 7, 2, 0, 4, 12 };
            int[] expectedOutput = { 0, 1, 2, 3, 4, 4, 5, 7, 7, 12 };

            var algorythm = new Algorythm();
            var output = algorythm.Sort(input);

            Assert.Equal(expectedOutput, output);
        }
    }
}

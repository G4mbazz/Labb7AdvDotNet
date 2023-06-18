using Labb7AdvDotNet.Data;
namespace Labb7AdvDotNet_Test
{
    public class CalculateTest
    {
        [Theory]
        [InlineData(7f, 8f, "7 + 8 = 15")]
        [InlineData(4f, 5f, "4 + 5 = 9")]
        [InlineData(3.25f, 8.75f, "3,25 + 8,75 = 12")]
        [InlineData(245f, 486f, "245 + 486 = 731")]
        [InlineData(38.1f, 521f, "38,1 + 521 = 559,1")]
        public void AdditionTest_ShouldReturnCorrectResult_WhenGivenCorrectNumbers(float value, float value1, string expected)
        {
            Tuple<float, float> values = new(value, value1);
            string actual = Calculate.Addition(values);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(23f, 8f, "23 - 8 = 15")]
        [InlineData(-4f, -5f, "-4 - -5 = 1")]
        [InlineData(100f, 8.75f, "100 - 8,75 = 91,25")]
        [InlineData(245f, 486f, "245 - 486 = -241")]
        [InlineData(52.45f, 521.15f, "52,45 - 521,15 = -468,7")]
        public void SubtractionTest_ShouldReturnCorrectResult_WhenGivenCorrectNumbers(float value, float value1, string expected)
        {
            Tuple<float, float> values = new(value, value1);
            string actual = Calculate.Subtraction(values);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3f, 5f, "3 * 5 = 15")]
        [InlineData(-4f, -5f, "-4 * -5 = 20")]
        [InlineData(4f, -5f, "4 * -5 = -20")]
        [InlineData(265f, 7f, "265 * 7 = 1855")]
        [InlineData(23f, 48f, "23 * 48 = 1104")]
        public void MultiplicationTest_ShouldReturnCorrectResult_WhenGivenCorrectNumbers(float value, float value1, string expected)
        {
            Tuple<float, float> values = new(value, value1);
            string actual = Calculate.Multiplication(values);
            Assert.Equal(expected, actual);
        }
    }
}
using MeganLibrary;
using Xunit.Sdk;

namespace TestMeganLibrary
{
    public class TestNumberLIbrary
    {
        [Fact]
        public void TestPI()
        {
            Assert.Equal(3.145, Numberlibrary.PI);

        }
        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(-3, -1, -2)]
        [InlineData(-1, 1, -2)]
        public void TestAdd(int sum, int a, int b) {
            Assert.Equal(sum, Numberlibrary.Add(a, b));

        }
        [Theory]
        [InlineData(5, 7, 2)]
        [InlineData(-5, -7, -2)]
        [InlineData(4, 3, -1)]
        public void TestSubtract(int sum, int a, int b)
        {
            Assert.Equal(sum, Numberlibrary.Subtract(a, b));
        }
        [Theory]
        [InlineData(6, 2, 3)]
        public void TestMultiply(int sum, int a, int b)
        {
            Assert.Equal(sum, Numberlibrary.Multiply(a, b));
        }
        [Theory]
        [InlineData(3, 6, 2)]
        public void TestDivide(int sum, int a, int b)
        {
            Assert.Equal(sum, a/b);
        }
        [Theory]
        [InlineData(1, 5, 2)]
        public void TestModulo(int sum, int a, int b)
        {
            Assert.Equal(sum, a % b);
        }
        [Theory]
        [InlineData(8, 2)]
        public void TestCubed(int sum, int a)
        {
            Assert.Equal(sum, a * a * a);
        }
        [Theory]
        [InlineData(0, 6, 2)]
        public void TestIsEven(int sum, int a, int b)
        {
            Assert.Equal(sum, a - (a / b * b));
        }
        [Theory]
        [InlineData(1, 5, 2)]
        public void TestIsOdd(int sum, int a, int b)
        {
            Assert.Equal(sum, a - (a / b * b));
        }
    }
}
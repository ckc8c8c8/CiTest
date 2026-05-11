using CITest;
using System.Reflection;

namespace CIxunitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Add()
        {
            // Arrange
            var calc = new Class1();

            // Act
            int result = calc.Add(2, 3);

            // Assertd
            Assert.Equal(5, result);
        }
    }
}

using Enhetstesting;
using Xunit;
namespace CalcTests
{
    public class CalculatorTests
    {
        
        [Fact]
        public void TestAddNumbers()
        {
            //Arrange
            var calc = new Calculator();
            double result = 0;

            //Act
            result = calc.AddNumbers(3, 5);

            //Assert
            Assert.Equal(8, result);
        }

    }
}

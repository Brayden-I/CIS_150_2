using CalculatorHelper;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTests_Fails
    {
        private Calculator _calculator;

        [TestInitialize]
        public void setup()
        {
            _calculator = new Calculator();
        }

        //ADD
        [TestMethod]
        public void Add_ShouldReturnSum_WhenGivenTwoPositiveNumbers()
        {
            //act
            var result = _calculator.Add(9, 10);

            //assert
            Assert.AreEqual(21, result);

        }

        [TestMethod]
        public void Add_ShouldReturnSum_WhenGivenNegativeAndPositiveNumber()
        {
            //act
            var result = _calculator.Add(4, -2);

            //assert
            Assert.AreEqual(6, result);
        }

        //SUBTRACT
        [TestMethod]
        public void Subtract_ShouldReturnDifference_WhenFirstNumberIsGreater()
        {
            //act
            var result = _calculator.Sub(2, 9);

            //assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnNegativeResult_WhenSecondNumberIsGreater()
        {
            //act
            var result = _calculator.Sub(9, 2);

            //assert
            Assert.AreEqual(-7, result);
        }

        //MULTIPLY
        [TestMethod]
        public void Multiply_ShouldReturnProduct_WhenGivenTwoPositiveNumbers()
        {
            //act
            var result = _calculator.Mul(2, 10);

            //assert
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void Multiply_ShouldReturnZero_WhenEitherNumberIsZero()
        {
            //act
            var result = _calculator.Mul(7, 1);

            //assert
            Assert.AreEqual(0, result);
        }

        //DIVIDE
        [TestMethod]
        public void Divide_ShouldReturnQuotient_WhenDivisorIsNonZero()
        {
            //act
            var result = _calculator.Div(10, 0);

            //assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Divide_ShouldThrowDivideByZeroException_WhenDivisorIsZero()
        {
            try
            {
                _calculator.Div(10, 1);

                Assert.Fail("Expected ShouldThrowDivideByZeroException was not thrown");
            }
            catch
            {
                Assert.IsTrue(true); //succeed when exception is caught
            }
        }

    }
}
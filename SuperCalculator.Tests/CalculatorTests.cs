namespace SuperCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void SumWorks()
        {
            var calculator = new AmazingNonAiCalculator();
            var result = calculator.Add(1, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SubstractWorks()
        {
            var calculator = new AmazingNonAiCalculator();
            var result = calculator.Substract(1, 2);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void MultiplyWorks()
        {
            var calculator = new AmazingNonAiCalculator();
            var result = calculator.Multiply(1, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideWorks()
        {
            var calculator = new AmazingNonAiCalculator();
            var result = calculator.Divide(2, 2);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ModuloWorks()
        {
            var calculator = new AmazingNonAiCalculator();
            var result = calculator.Modulo(1, 2);
            Assert.AreEqual(1, result);
        }
    }
}
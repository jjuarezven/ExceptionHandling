using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator.Tests.MSTest
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void Test()
        {
            var test = new MyTest();
            var result = test.TestMethod();
            Assert.AreEqual("13728169", result);
        }
        //[TestMethod]
        //public void ThrownWhenUnsupportedOperation()
        //{
        //    var sut = new Calculator();
        //    Assert.ThrowsException<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "-"));
        //    var ex = Assert.ThrowsException<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "-"));
        //    Assert.AreEqual("-", ex.Operation);
        //}
    }
}

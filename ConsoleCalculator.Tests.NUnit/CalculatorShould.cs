using NUnit.Framework;

namespace ConsoleCalculator.Tests.NUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ThrownWhenUnsupportedOperation()
        {
            var sut = new Calculator();
            Assert.That(() => sut.Calculate(1, 1, "-"), Throws.TypeOf<CalculationOperationNotSupportedException>());
            
            Assert.That(() => sut.Calculate(1, 1, "-"), 
                Throws.TypeOf<CalculationOperationNotSupportedException>()
                .With.Property("Operation").EqualTo("-")
                );

            Assert.That(() => sut.Calculate(1, 1, "+"),
                Throws.InstanceOf<CalculationException>());
            
            // syntaxis similar to mstest
            Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "-"));
            var ex = Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "-"));
            Assert.That(ex.Operation, Is.EqualTo("-"));
        }
    }
}
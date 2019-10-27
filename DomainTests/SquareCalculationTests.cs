using AsyncExamples.Domain.Calculators;
using AsyncExamples.Domain.Utils;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AsyncExamples.DomainTests
{
    [TestClass]
    public class SquareCalculationTests
    {
        [TestMethod]
        public void TheSquareOf15Is225()
        {
            // Arrange
            var calculator = new SquareCalculator();
            var log = new CalculationLog();

            // Act
            calculator.Calculate(15, log);

            // Assert
            log.Items.Single().Result.Should().Be(225);
        }
    }
}

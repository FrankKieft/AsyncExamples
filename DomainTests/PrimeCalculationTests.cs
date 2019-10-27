using AsyncExamples.Domain.Calculators;
using AsyncExamples.Domain.Utils;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AsyncExamples.DomainTests
{
    [TestClass]
    public class PrimeCalculationTests
    {
        [TestMethod]
        public void TheFifthPrimeIs11()
        {
            // Arrange
            var calculator = new PrimeCalculator();
            var log = new CalculationLog();

            // Act
            calculator.Calculate(5, log);

            // Assert
            log.Items.Single().Result.Should().Be(11);
        }
        [TestMethod]
        public void TheNighntPrimeIs23()
        {
            // Arrange
            var calculator = new PrimeCalculator();
            var log = new CalculationLog();

            // Act
            calculator.Calculate(9, log);

            // Assert
            log.Items.Single().Result.Should().Be(23);
        }

        [TestMethod]
        public void TheFirstPrimeIs2()
        {
            // Arrange
            var calculator = new PrimeCalculator();
            var log = new CalculationLog();

            // Act
            calculator.Calculate(1, log);

            // Assert
            log.Items.Single().Result.Should().Be(2);
        }
    }
}

using AsyncExamples.Domain.Calculators;
using AsyncExamples.Domain.Utils;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AsyncExamples.DomainTests
{
    [TestClass]
    public class Sha256HashcodeFactorCalculationTests
    {
        [TestMethod]
        public void TheHashcodeFactorOf25Is1234ToMakeTheHashEndOn0000()
        {
            // Arrange
            var calculator = new Sha256HashFactorCalculator();
            var log = new CalculationLog();

            // Act
            calculator.Calculate(25, log);

            // Assert
            log.Items.Single().Result.Should().Be(1494000);
        }
    }
}

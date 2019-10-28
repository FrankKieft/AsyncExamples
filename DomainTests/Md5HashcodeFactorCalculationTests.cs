using AsyncExamples.Domain.Calculators;
using AsyncExamples.Domain.Utils;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AsyncExamples.DomainTests
{
    [TestClass]
    public class Md5HashcodeFactorCalculationTests
    {
        [TestMethod]
        public void TheHashcodeFactorOf25Is4153602ToMakeHashEndWith00000()
        {
            // Arrange
            var calculator = new Md5HashFactorCalculator(1);
            var log = new CalculationLog();

            // Act
            calculator.Calculate(25, log);

            // Assert
            log.Items.Single().Result.Should().Be(4153602);
        }
    }
}

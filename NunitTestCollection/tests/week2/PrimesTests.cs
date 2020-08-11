using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using System.Globalization;
using SzkolaDotNet.Week2;

namespace NunitTestCollection
{
    class PrimesTests
    {
        Number prime;

        [SetUp]
        public void SetUpTests()
        {
            prime = new Number();
        }

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(29)]
        public void ShouldReturnTrueWhenPrimeNumberProvied(int number)
        {
            prime.CheckIfIsPrime(number).Should().Be(true);
        }

        [TestCase(4)]
        [TestCase(8)]
        [TestCase(12)]
        [TestCase(84)]
        public void ShouldReturnFalseWhenNotPrimeNumberProvied(int number)
        {
            prime.CheckIfIsPrime(number).Should().Be(false);
        }

        [TestCase(1, 5, 3)]
        [TestCase(1, 100, 25)]
        public void ShouldReturnNumberOfPrimesInRange(int start, int end, int result)
        {
            prime.CountPrimesInRange(start, end).Should().Be(result);
        }
    }
}

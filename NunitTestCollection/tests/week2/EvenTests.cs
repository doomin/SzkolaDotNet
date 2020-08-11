using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using SzkolaDotNet.Week2;

namespace NunitTestCollection.tests.week2
{
    class EvenTests
    {
        Number num;

        [SetUp]
        public void SetUpTests()
        {
            num = new Number();
        }
        [TestCase(2)]
        [TestCase(22)]
        [TestCase(128)]
        [TestCase(24564)]
        public void ShouldReturnTrueWhenEvenNumberGiven(int testNumber)
        { 
            num.IsEven(testNumber).Should().Be(true);
        }

        [TestCase(24563)]
        public void ShouldReturnFalseWhenEvenNumberGiven(int testNumber)
        {
            num.IsEven(testNumber).Should().Be(false);
        }

        [TestCase(1,10,5)]
        [TestCase(1, 12, 6)]
        public void ShouldCountEvensInGivenRange(int start, int end, int result)
        {
            num.CountEvensInRange(start, end).Should().Be(result);

        }

        [TestCase()]
        public void ShouldReturnAllEvensInRange()
        {
            List<int> result = new List<int>() {2,4,6,8,10 };
            num.ReturnAllEvensInRange(1, 10).Should().Equal(result);
        }

    }
}

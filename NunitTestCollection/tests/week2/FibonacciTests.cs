using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using SzkolaDotNet.Week2;

namespace NunitTestCollection.tests.week2
{
    class FibonacciTests
    {
        Number num;

        [SetUp]
        public void SetUptests()
        {
            num = new Number();
        }

        [Test]
        public void ShouldReturnFibonacciSequenceForGivenLenght()
        {
            List<int> result = new List<int> {0,1,1,2,3,5,8,13,21 };
            num.FibonacciSequence(9).Should().Equal(result);
        }
    }
}

using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using SzkolaDotNet.Week2;

namespace NunitTestCollection.tests.week2
{
    class PowerTests
    {
        [Test]
        public void ShouldReturnPower3WhenNumberGiven()
        {
            Number num = new Number();
            num.ReturnPowerThree(2).Should().Be(8);
        }
    }
}

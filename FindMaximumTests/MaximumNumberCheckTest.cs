using FindMaximum;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumTests
{
    [TestFixture]
    class MaximumNumberCheckTest
    {
        

        [Test]
        [TestCase(1,2,3,3)]
        [TestCase(1, 3, 2,3)]
        [TestCase(3, 1, 2,3)]
        public void MaximumIntegerNumber_WhenCalled_ReturnsMaximumInterger(int integer1, int integer2,int integer3, int max)
        {
            var result = MaximumNumberCheck.MaximumIntegerNumber(integer1, integer2, integer3);

            Assert.That(result, Is.EqualTo(max));
        }

    }
}

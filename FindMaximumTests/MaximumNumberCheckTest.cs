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

        [Test]
        [TestCase(1.1, 2.2, 3.3, 3.3)]
        [TestCase(1.1, 3.3, 2.2, 3.3)]
        [TestCase(3.3, 1.1, 2.2, 3.3)]
        public void MaximumdoubleNumber_WhenCalled_ReturnsMaximumdouble(double double1, double double2, double double3, double max)
        {
            var result = MaximumNumberCheck.MaximumFloatNumber(double1, double2, double3);

            Assert.That(result, Is.EqualTo(max));
        }

        [Test]
        [TestCase("Apple", "Banana", "Peach", "Peach")]
        [TestCase("Peach", "Banana", "Apple", "Peach")]
        [TestCase("Banana", "Peach", "Apple", "Peach")]
        public void MaximumstringNumber_WhenCalled_ReturnsMaximumstring(string string1, string string2, string string3, string max)
        {
            var result = MaximumNumberCheck.MaximumString(string1, string2, string3);

            Assert.That(result, Is.EqualTo(max));
        }

        [Test]
        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 1, 2, 3)]
        public void Max_WhenCalled_ReturnsMaximumInterger(int integer1, int integer2, int integer3, int max)
        {
            var result = MaximumNumberCheck.Max(integer1, integer2, integer3);

            Assert.That(result, Is.EqualTo(max));
        }

        [Test]
        [TestCase(1.1, 2.2, 3.3, 3.3)]
        [TestCase(1.1, 3.3, 2.2, 3.3)]
        [TestCase(3.3, 1.1, 2.2, 3.3)]
        public void Max_WhenCalled_ReturnsMaximumdouble(double double1, double double2, double double3, double max)
        {
            var result = MaximumNumberCheck.Max(double1, double2, double3);

            Assert.That(result, Is.EqualTo(max));
        }

        [Test]
        [TestCase("Apple", "Banana", "Peach", "Peach")]
        [TestCase("Peach", "Banana", "Apple", "Peach")]
        [TestCase("Banana", "Peach", "Apple", "Peach")]
        public void Max_WhenCalled_ReturnsMax(string string1, string string2, string string3, string max)
        {
            var result = MaximumNumberCheck.Max(string1, string2, string3);

            Assert.That(result, Is.EqualTo(max));
        }
    }
}

using FindMaximum;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumTests
{
    [TestFixture]
    class GenericMaximumTest
    {
        [Test]
        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 1, 2, 3)]
        public void Max_WhenCalled_ReturnsMaximumInterger(int integer1, int integer2, int integer3, int max)
        {
            var genericMaximum = new GenericMaximum<int>(integer1, integer2, integer3);

            var result = genericMaximum.Max();

            Assert.That(result, Is.EqualTo(max));
        }

        [Test]
        [TestCase(1.1, 2.2, 3.3, 3.3)]
        [TestCase(1.1, 3.3, 2.2, 3.3)]
        [TestCase(3.3, 1.1, 2.2, 3.3)]
        public void Max_WhenCalled_ReturnsMaximumdouble(double double1, double double2, double double3, double max)
        {
            var genericMaximum = new GenericMaximum<double>(double1, double2, double3);

            var result = genericMaximum.Max();

            Assert.That(result, Is.EqualTo(max));
        }

        [Test]
        [TestCase("Apple", "Banana", "Peach", "Peach")]
        [TestCase("Peach", "Banana", "Apple", "Peach")]
        [TestCase("Banana", "Peach", "Apple", "Peach")]
        public void Max_WhenCalled_ReturnsMaxString(string string1, string string2, string string3, string max)
        {
            var genericMaximum = new GenericMaximum<string>(string1, string2, string3);

            var result = genericMaximum.Max();

            Assert.That(result, Is.EqualTo(max));
        }
    }
}

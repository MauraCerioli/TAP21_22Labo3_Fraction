using System;
using NUnit.Framework;
using Fraction;

namespace Fraction.Tests {
    
    [TestFixture]
    public class FractionConstructorTest {
        [Test]
        public void TrivialOk(){
            var num = 3;
            var den = 17;
            var f = new Fraction(num, den);
            Assert.Multiple(() => {
                Assert.That(f.Numerator, Is.EqualTo(num));
                Assert.That(f.Denominator, Is.EqualTo(den));
            });
        }
    }
}

using System;
using NUnit.Framework;
using Fraction;

namespace Fraction.Tests {
    [TestFixture]
    public class FractionConstructorTest{
        [TestCase(3,7)]
        [TestCase(-9,55)]
        [TestCase(0,1)]
        public void TrivialCase(int num, int den){
            var f = new Fraction(num, den);
            Assert.Multiple(() => {
                Assert.That(f.Numerator, Is.EqualTo(num));
                Assert.That(f.Denominator,Is.EqualTo(den));
            });
        }

        [TestCase(3, -4, -3, 4)]
        [TestCase(3,5,3,5)]
        [TestCase(-3,7,-3,7)]
        [TestCase(-3,-11,3,11)]
        [TestCase(3*7, -4*7, -3, 4)]
        [TestCase(3*67,5*67,3,5)]
        [TestCase(-3*89,7*89,-3,7)]
        [TestCase(-3*65,-11*65,3,11)]
        [TestCase(3*8,5*8,3,5)]
        [TestCase(0,7,0,1)]
        [TestCase(0,-3,0,1)]
        public void StandardCase(int num, int den, int expectedNum, int expectedDen){
            var f = new Fraction(num, den);
            Assert.Multiple((() => {
                Assert.That(f.Numerator,Is.EqualTo(expectedNum));
                Assert.That(f.Denominator,Is.EqualTo(expectedDen));
            }));
        }
        [TestCase(7)]
        [TestCase(-86)]
        [TestCase(0)]
        public void ZeroDenThrows(int num){
            Assert.That(()=>new Fraction(num,0),Throws.InstanceOf<ArgumentOutOfRangeException>());
        }
    }
}

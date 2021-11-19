using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fraction.Tests {
    [TestFixture]
    public class PlusOperatorTest {
        [TestCase(3,5,9,5,12,5)]
        [TestCase(3,5,7,5,2,1)]
        [TestCase(7,9,-7,9,0,1)]
        [TestCase(11,3,-7,3,4,3)]
        [TestCase(7,15,11,3,62,15)]
        [TestCase(7,15,13,3,24,5)]
        public void StandardCase(int n1, int d1, int n2, int d2, int expectedN, int expectedD){
            var f1 = new Fraction(n1, d1);
            var f2 = new Fraction(n2, d2);
            var result = f1 + f2;
            Assert.Multiple(() => {
                Assert.That(result.Numerator,Is.EqualTo(expectedN));
                Assert.That(result.Denominator,Is.EqualTo(expectedD));
            });
        }
    }
}

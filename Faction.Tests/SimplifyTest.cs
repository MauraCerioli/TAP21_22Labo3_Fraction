using System;
using NUnit.Framework;
using Fraction;
using Microsoft.VisualBasic;

namespace Fraction.Tests {
    
    [TestFixture]
    public class SimplifyTest {
        [TestCase(3,3,17,17)]
        [TestCase(3,-3,-17,17)]
        [TestCase(3*45,3,17*45,17)]
        public void CorrectCase(int nIn, int nOut,int dIn, int dOut){
            Fraction.Simplify(ref nIn,ref dIn);
            Assert.Multiple(() => {
                Assert.That(nIn, Is.EqualTo(nOut));
                Assert.That(dIn, Is.EqualTo(dOut));
            });
        }
    }
}
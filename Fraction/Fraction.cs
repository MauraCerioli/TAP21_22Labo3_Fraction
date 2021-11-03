using System;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("Fraction.Tests")]


namespace Fraction {
    public class Fraction {
        public int Numerator{ get; }
        public int Denominator{ get; }
        static int GCD(int p, int q){
            return q == 0? p:GCD(q, p % q);
        }
        internal static void Simplify(ref int n, ref int d){
            if (0==d)
                throw new ArgumentOutOfRangeException(nameof(d), "The denominator cannot be zero");
            var positive = Math.Sign(n) == Math.Sign(d);
            n = Math.Abs(n);
            d = Math.Abs(d);
            var gcd = GCD(n, d);
            n /= gcd;
            d /= gcd;
            if (!positive) n = -n;
        }

        public Fraction(int num, int den){
            Numerator = num;
            Denominator = den;
        }
    }
}

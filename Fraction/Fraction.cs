using System;
using System.Runtime.CompilerServices;

namespace Fraction {
    public class Fraction {
        public int Numerator{ get; }
        public int Denominator{ get; }
        
        public Fraction(int n, int d){
            //Only applies to positive numbers
            static int Gcd(int a, int b){
                while (a != b)
                    if (a < b) b -= a;
                    else a -= b;
                return a;
            }
            if (0 == d)
                throw new ArgumentOutOfRangeException(nameof(d), "Denominator cannot be 0");
            if (0==n){
                Numerator = 0;
                Denominator = 1;
            }
            else{
                var negative = Math.Sign(n)*Math.Sign(d);
                n = Math.Abs(n);
                d = Math.Abs(d);
                var gcd = Gcd(n,d);
                Numerator = negative*n/gcd;
                Denominator = d/gcd;
            }
        }

        public static Fraction operator +(Fraction x, Fraction y){
            return new Fraction(x.Numerator * y.Denominator + x.Denominator * y.Numerator,
                x.Denominator * y.Denominator);
        }
    }
}

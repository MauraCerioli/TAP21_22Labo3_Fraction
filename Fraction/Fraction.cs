using System;
using System.Runtime.CompilerServices;

namespace Fraction {
    public class Fraction {
        public int Numerator{ get; }
        public int Denominator{ get; }
        
        public Fraction(int n, int d){
            static int Gcd(int a, int b){
                a = Math.Abs(a);
                b = Math.Abs(b);
                while (a != b)
                    if (a < b) b = b - a;
                    else a = a - b;
                return a;
            }
            if (0 == d)
                throw new ArgumentOutOfRangeException(nameof(d), "Denominator cannot be 0");
            var gcd = Gcd(n,d);
            if (Math.Sign(n)!=Math.Sign(d)){
                n = -Math.Abs(n/gcd);
                d = Math.Abs(d/gcd);
            }
            else{
                n = Math.Abs(n/gcd);
                d = Math.Abs(d/gcd);
            }
            
            Numerator = n;
            Denominator = d;
        }

        public static Fraction operator +(Fraction x, Fraction y){
            return new Fraction(x.Numerator * y.Denominator + x.Denominator * y.Numerator,
                x.Denominator * y.Denominator);
        }
    }
}

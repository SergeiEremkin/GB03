using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05
{
    internal class RationalNumber
    {

        private int _numerator;     //числитель
        private int _denominator;   //знаменатель
        
        
        public RationalNumber(int numerator, int denominator)

        {
            if (denominator is 0)

            {
                throw new Exception("Знаменатель не должен быть равен 0");
            }
                    
            Numerator = numerator;
            Denominator = denominator;

        }

        public int Numerator

        {
            get => _numerator;

            set => _numerator = value;

        }

        public int Denominator

        {
            get => _denominator;

            set => _denominator = value;
        }


        public override string ToString()

        {
            if (Numerator % Denominator == 0)
            {
                var full = Numerator / Denominator;
                return full.ToString();
            }

            if (Numerator > Denominator)

            {
                var fullPart = Numerator / Denominator;

                var fraction = Numerator % Denominator;

                return fullPart + " " + fraction + "/" + Denominator;
            }

            return  Numerator + "/" + Denominator;
        }

        public override bool Equals(object obj)

        {
            return Equals(obj as RationalNumber);
        }

        public bool Equals(RationalNumber r)

        {
            if (r is null)

            {
                return false;
            }

            if (Object.ReferenceEquals(this, r))

            {
                return true;
            }

            if (this.GetType() != r.GetType())

            {
                return false;
            }

            return (Numerator == r.Numerator) && (Denominator == r.Denominator);
        }

        public override int GetHashCode()
        {
            return (Numerator, Denominator).GetHashCode();
        }

        public static bool operator ==(RationalNumber r1, RationalNumber r2)

        {
            return (r1.Numerator == r2.Numerator && r1.Denominator == r2.Denominator);
        }


        public static bool operator !=(RationalNumber r1, RationalNumber r2)

        {
            return (r1.Numerator != r2.Numerator || r1.Denominator != r2.Denominator);
        }

        public static bool operator <(RationalNumber r1, RationalNumber r2)

        {


            if (r1.Denominator == r2.Denominator)

            {
                return r1.Numerator < r2.Numerator;
            }

            return r1.Denominator < r2.Denominator;
        }

        public static bool operator >(RationalNumber r1, RationalNumber r2)

        {


            if (r1.Denominator == r2.Denominator)

            {
                return r1.Numerator > r2.Numerator;
            }

            return r1.Denominator > r2.Denominator;
        }

        public static bool operator <=(RationalNumber r1, RationalNumber r2)

        {
            if (r1.Denominator == r2.Denominator)

            {
                return r1.Numerator <= r2.Numerator;
            }

            return r1.Denominator <= r2.Denominator;
        }

        public static bool operator >=(RationalNumber r1, RationalNumber r2)

        {
            if (r1.Denominator == r2.Denominator)

            {
                return r1.Numerator >= r2.Numerator;
            }

            return r1.Denominator >= r2.Denominator;
        }

        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)

        {
            RationalNumber r3 = new RationalNumber(1, 2);

            r3.Numerator = (r1.Numerator * r2.Denominator + r1.Denominator * r2.Numerator);

            r3.Denominator = r1.Denominator * r2.Denominator;

            RationalNumber.RoundNumber(r3);

            return r3;
        }

        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)

        {
            RationalNumber r3 = new RationalNumber(1, 2);

            r3.Numerator = (r1.Numerator * r2.Denominator - r1.Denominator * r2.Numerator);

            r3.Denominator = r1.Denominator * r2.Denominator;

            RationalNumber.RoundNumber(r3);

            return r3;
        }

        public static RationalNumber operator ++(RationalNumber r1)

        {
            r1.Numerator++;

            r1.Denominator++;

            return r1;
        }

        public static RationalNumber operator --(RationalNumber r1)

        {
            r1.Numerator--;

            r1.Denominator--;

            return r1;
        }

        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)

        {
            RationalNumber r3 = new RationalNumber(1,1);

            r3.Numerator = r1.Numerator * r2.Numerator;

            r3.Denominator = r1.Denominator * r2.Denominator;

            RationalNumber.RoundNumber(r3);

            return r3;

        }

        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)

        {
            RationalNumber r3 = new RationalNumber(1,1);

            r3.Numerator = r1.Numerator * r2.Denominator;

            r3.Denominator = r1.Denominator * r2.Numerator;

            RationalNumber.RoundNumber(r3);

            return r3;

        }

        public static RationalNumber operator %(RationalNumber r1, RationalNumber r2)

        {
            RationalNumber r3 = new RationalNumber(1, 1);

            r3.Numerator =r1.Numerator -  (r1.Numerator * r2.Denominator);

            r3.Denominator =r1.Denominator - (r1.Denominator * r2.Numerator);

            RationalNumber.RoundNumber(r3);

            return r3;

        }

        public static RationalNumber RoundNumber (RationalNumber r1)

        {
            int max = 0;

            if (r1.Numerator > r1.Denominator)

            {
                max = Math.Abs(r1.Denominator);
            }

            else

            {
                max = Math.Abs(r1.Numerator);
            }

            for (int i = max; i >= 2; i--)

            {

                if (r1.Numerator % i == 0 && r1.Denominator % i == 0)

                {
                    r1.Numerator = r1.Numerator / i;

                    r1.Denominator = r1.Denominator / i;

                }
            }

                if (r1.Denominator < 0)

                {
                    r1.Numerator = (-1) * r1.Numerator;

                    r1.Denominator = Math.Abs(r1.Denominator);
                }

                return r1;
            
        }

        public static implicit operator int(RationalNumber r1)
        {

            return r1.Numerator / r1.Denominator;
        }

        public static implicit operator float(RationalNumber r1)
        {

            return (float)r1.Numerator / r1.Denominator; 
        }





    }

}

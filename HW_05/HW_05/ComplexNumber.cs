using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05
{
    internal class ComplexNumber
    {
        private double _re;     //действительная часть
        private double _im;    //мнимая часть
        private string _i;      //мнимая единица

        public ComplexNumber(double re, double im)
        {
            Re = re;
            Im = im;
            I = "i";

        }

        public double Re
        {
            get => _re;

            set => _re = value;
        }

        public double Im
        {
            get => _im;

            set => _im = value;
        }

        public string I
        {
            get => _i;

            private set => _i = value;
        }

        public override string ToString()
        {
            if (Im > 0)
            {
                return Re + " + " + Im + " * " + I;
            }

            if (Im < 0)
            {
                return Re + " " + Im + " * " + I;
            }
            else
            {
                return Re.ToString();
            }
        }

        public static ComplexNumber operator +(ComplexNumber complex1, ComplexNumber complex2)
        {
            var complex3 = new ComplexNumber(1, 2);

            complex3.Re = complex1.Re + complex2.Re;

            complex3.Im = complex1.Im + complex2.Im;

            return complex3;

        }

        public static ComplexNumber operator -(ComplexNumber complex1, ComplexNumber complex2)
        {
            var complex3 = new ComplexNumber(1, 2);

            complex3.Re = complex1.Re - complex2.Re;

            complex3.Im = complex1.Im - complex2.Im;

            return complex3;

        }

        public static ComplexNumber operator *(ComplexNumber complex1, ComplexNumber complex2)
        {
            var complex3 = new ComplexNumber(1, 2);

            complex3.Re = complex1.Re * complex2.Re - complex1.Im * complex2.Im;

            complex3.Im = complex1.Re * complex2.Im + complex1.Im * complex2.Re;

            return complex3;
        }

        public override bool Equals(object obj)

        {
            return base.Equals(obj as ComplexNumber);
        }

        public bool Equals(ComplexNumber complex)

        {
            if (complex is null)
            {
                return false;
            }

            if (Object.ReferenceEquals(this, complex))

            {
                return true;
            }

            return (Re == complex.Re && Im == complex.Im);
        }

        public override int GetHashCode()
        {
            return (Re, Im).GetHashCode();
        }

        public static bool operator ==(ComplexNumber complex1, ComplexNumber complex2)
        {

            return (complex1.Re == complex2.Re && complex1.Im == complex2.Im);
        }

        public static bool operator !=(ComplexNumber complex1, ComplexNumber complex2)
        {
            
            return (complex1.Re != complex2.Re || complex1.Im != complex2.Im);
        }
    }
}




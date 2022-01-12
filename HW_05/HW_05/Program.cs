using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RationalNumber number1 = new RationalNumber(120, 67);  

            RationalNumber number2 = new RationalNumber(2, 3);

            number1.Equals(number2);

            number1.GetHashCode();

            var number4 = number1 / number2;

            var number3 = number1 % number2;

            Console.WriteLine(number1);

            Console.WriteLine(number3);

            var complex = new ComplexNumber(2, 3);

            var complex2 = new ComplexNumber(3, 5);

            var complex3 = complex + complex2;

            var complex4 = complex - complex2;

            var complex5 = complex * complex2;

            Console.WriteLine(complex4);

            Console.WriteLine(complex3);

            Console.WriteLine(complex5);

            complex.Equals(complex2);

            Console.WriteLine(complex.Equals(complex2));

            float a;

            a = number1;

            Console.WriteLine(a);

            Console.ReadLine();
            
        }
    }
}

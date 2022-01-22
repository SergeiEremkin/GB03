using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03
{

    /*
     * Реализовать метод, который в качестве входного параметра принимает строку string,
     * возвращает строку типа string, буквы в которой идут в обратном порядке. Протестировать метод.
     */

    internal class Program
    {
        public static string Reverse (string text)
        {
            char[] arr = text.ToCharArray();

            Array.Reverse(arr);

            return new string(arr);
          
        }
        static void Main(string[] args)
        {
            string text = "с новым годом";

           Console.WriteLine( Reverse(text) );

            Console.ReadLine();
        }
    }
}

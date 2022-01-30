using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "ЖИЛИ У БАБУСИ ДВА ВЕСЕЛЫХ ГУСЯ";

            ACoder acoder = new ACoder();

            string coded =  acoder.Encode(input);

            Console.WriteLine(coded);

            Console.WriteLine(acoder.Decode(coded));

            BCoder bcoder = new BCoder();

            string coded2 = bcoder.Encode(input);

            Console.WriteLine(coded2);

            Console.WriteLine(bcoder.Decode(coded2));

            Console.ReadLine();
        }
    }
}

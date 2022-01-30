using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var testAccount = new BankAccount(300, Type.USD);


            var testAccount2 = new BankAccount(300, Type.USD);

            var testAccount3 = new BankAccount( 200, Type.RUB);

            BankAccount.WhithDrow(500, testAccount);

            Console.WriteLine();

            BankAccount.WhithDrow(400, testAccount2);

            Console.WriteLine();

            BankAccount.PutOnTheAccount(450, testAccount);

            Console.WriteLine(testAccount = testAccount2);

            testAccount.TransferringMoney(testAccount2, 100);

            testAccount.Equals(testAccount2);

            Console.WriteLine(testAccount.GetHashCode());

            Console.WriteLine(testAccount2.GetHashCode());

            Console.WriteLine(testAccount3.ToString());

            Console.ReadLine();
        }
    }
}

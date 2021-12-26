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

            var testAccount = new BankAccount { Balance = 550, Type = Type.EUR };

            var testAccount2 = new BankAccount { Balance = 300, Type = Type.EUR };

            BankAccount.WhithDrow(500, testAccount);

            Console.WriteLine();

            BankAccount.WhithDrow(400, testAccount2);

            Console.WriteLine();

            BankAccount.PutOnTheAccount(450, testAccount);

            Console.WriteLine();

            testAccount.TransferringMoney(testAccount2, 100);

            Console.ReadLine();
        }
    }
}

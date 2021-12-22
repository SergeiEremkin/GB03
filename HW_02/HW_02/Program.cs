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
                      
            var testAccount = new BankAccount {Balance = 200, Type = Type.EUR };

            Console.WriteLine("Счет №" + "" + testAccount.Number + "\nБаланс " + testAccount.Balance + " " + testAccount.Type);

            Console.WriteLine();

            BankAccount.WhithDrow(1300,testAccount);

            Console.WriteLine();

            BankAccount.WhithDrow(100, testAccount);

            Console.WriteLine();

            BankAccount.PutOnTheAccount(1000, testAccount);

            Console.ReadLine();
        }
    }
}

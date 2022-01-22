using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_02
{
    enum Type
    {
        RUB,
        EUR,
        USD
    };

    class BankAccount
    {
        private int _number;

        private int _balance;

        private Type _type;

        private static int _counter = 1;

        public int Number
        {
            get
            {
                return _number;
            }
            private set
            {
                _number = value;
            }
        }

        public int Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                _balance = value;
            }

        }

        public Type Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }
       
        public BankAccount() : this(0)
        {
            RandomNumber();
        }

        public BankAccount(int balance) : this(balance,Type.EUR)
        {
            RandomNumber();
        }

        public BankAccount(int balance, Type type) 
        {
            RandomNumber();
            Balance = balance;
            Type = type;
        }
      
        private void RandomNumber()
        {
            Number = _counter++;
        }

       
        public static void WhithDrow(int summ, BankAccount bankAccount)
        {
            if ((bankAccount.Balance) >= summ)
            {
                bankAccount.Balance = bankAccount.Balance - summ;

                Console.WriteLine($"Сумма {summ} {bankAccount.Type} снята cо счета № {bankAccount.Number}. Баланс составляет: {bankAccount.Balance} {bankAccount.Type}");
            }

            else
            {
                Console.WriteLine($"На счете № {bankAccount.Number} не достаточно средств");
            }

        }

        public static void PutOnTheAccount(int summ, BankAccount bankAccount)
        {
            bankAccount.Balance = bankAccount.Balance + summ;

            Console.WriteLine($"Пополнение на сумму: {summ} {bankAccount.Type} на счет № {bankAccount.Number}. Баланс составляет: {bankAccount.Balance} {bankAccount.Type} ");
        }

        public void TransferringMoney (BankAccount bankAccount, int summ)
        {

            if (bankAccount.Balance < summ || bankAccount is null)
            {
                return;
            }

            bankAccount.Balance -= summ;

            Balance += summ;

            Console.WriteLine($"Сумма {summ} {bankAccount.Type} переведена со счета № {bankAccount.Number} на № {Number}");
        }

    }
}

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

        // public static int _rndNumber = NumberGen(); Тестовая переменная для рэндомного счета

        public int Number
        {
            get
            {
                return _number;
            }

            set
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
            Number = NumberGen();
        }

        public BankAccount(int number) : this(1, 2)
        {
            Number = NumberGen();
        }

        public BankAccount(int number, int balance) : this(2, 3, Type.RUB)
        {
            Number = NumberGen();
        }

        public BankAccount(int number, int balance, Type type)
        {
            Number = NumberGen();
            Balance = balance;
            Type = type;

        }

        public static int NumberGen()

        {

            var rnd = new Random();

            return rnd.Next(1000, 1000000);

        }

        public static void WhithDrow(int summ, BankAccount bankAccount)
        {
            if ((bankAccount.Balance) >= summ)
            {
                bankAccount.Balance = bankAccount.Balance - summ;

                Console.WriteLine($"Сумма {summ} {bankAccount.Type} снята. Баланс составляет: {bankAccount.Balance} {bankAccount.Type}");
            }

            else
            {
                Console.WriteLine("На балансе не достаточно средств");
            }

        }

        public static void PutOnTheAccount(int summ, BankAccount bankAccount)
        {
            bankAccount.Balance = bankAccount.Balance + summ;

            Console.WriteLine($"Пополнение на сумму: {summ} {bankAccount.Type}. Баланс составляет: {bankAccount.Balance} {bankAccount.Type} ");
        }

    }
}

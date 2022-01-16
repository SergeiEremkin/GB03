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

        public override string ToString()
        {
            return $"Acc. {Number} Balance {Balance} {Type}";
        }

        public override bool Equals(object obj)

        {
            return base.Equals(obj as BankAccount);
        }

        public bool Equals(BankAccount bankAccount)

        {
            if (bankAccount is null)
            {
                return false;
            }

            if (Object.ReferenceEquals(this, bankAccount))

            {
                return true;
            }

            return (Number == bankAccount.Number && Balance == bankAccount.Balance && Type == bankAccount.Type);
        }

        public override int GetHashCode()
        {
            return (Number, Balance, Type).GetHashCode();
        }

        public static bool operator ==(BankAccount bankAccount1, BankAccount bankAccount2)
        {

            return (bankAccount1.Number == bankAccount2.Number && bankAccount1.Balance == bankAccount2.Balance && 
                bankAccount1.Type == bankAccount2.Type);
        }

        public static bool operator !=(BankAccount bankAccount1, BankAccount bankAccount2)
        {

            return (bankAccount1.Number != bankAccount2.Number || bankAccount1.Balance != bankAccount2.Balance ||
                bankAccount1.Type != bankAccount2.Type);
        }

    }
}

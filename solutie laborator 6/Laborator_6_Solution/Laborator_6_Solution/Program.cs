using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laborator_6_Solution
{
    enum AccountType { Cec, Deposit }

    class BankAccount
    {

        //varianta veche

        /*
        public void Populate(long nr, decimal dob, AccountType tip)
        {
            accNumber = nr;
            dobandaCont = dob;
            accType = tip;
        }
        */

        //varianta noua

        public void Populate(decimal amount, AccountType tip)
        {
            accNumber = NextNumber();
            this.amount = amount;
            accType = tip;
        }

        public long AccNumber()
        {
            return accNumber;
        }

        public decimal Amount()
        {
            return amount;
        }

        public AccountType ReturnType()
        {
            return accType;
        }

        public static long NextNumber()
        {
            return succNrCont++;
        }

        public decimal Deposit(decimal amount)
        {
            this.amount += amount;
            return this.amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > this.amount)
                return false;

            this.amount -= amount;
            return true;
        }

        public static void TestDeposit(BankAccount cb)
        {
            Console.WriteLine("Introduceti suma pe care vreti sa o depuneti");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Noul sold este: {0}", cb.Deposit(amount));
        }

        public static void TestWithdraw(BankAccount cb)
        {
            Console.WriteLine("Introduceti suma pe care vreti sa o retrageti");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (cb.Withdraw(amount) == true)
                Console.WriteLine("Noul sold este: {0}", cb.Amount());
            else
                Console.WriteLine("Suma este prea mare");
        }

        private long accNumber;
        private decimal amount;
        private AccountType accType;
        private static long succNrCont = 123;
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            //account.accNumber = long.Parse(Console.ReadLine());
            //account.amount = 0.8M;
            //account.accType = accType.Deposit;

            long nr;

            //nr = long.Parse(Console.ReadLine());

            //OBSERVATIE - pentru ca metoda este statica va fi apelata la nivelul
            //clasei nu la nivelul obiectului (Nume_Clasa.Nume_Metoda)
            nr = BankAccount.NextNumber();

            account.Populate(50.8M, AccountType.Cec);


            Console.WriteLine("Informatii cont:\nnr {0}\ndobanda {1}\ntip {2}\n",
                account.AccNumber(), account.Amount(), account.ReturnType());


            BankAccount.TestDeposit(account);
            BankAccount.TestWithdraw(account);

            Console.ReadKey();
        }
    }
}

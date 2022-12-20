using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Exception
{
//Create custom exception for a Bank Account to throw an exception as InsufficientFundException

//To throw exception create an Account class and check on balance.

//Test the custom exception

    public class Account
    {
        public double Balance { get; private set; }

        public Account() { }

        public Account(double balance)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(Balance - amount < 0.0)
            {
                throw new InsufficientBalanceException("This withdrawal will result in an overdraft!");
            }
            else
            {
                Balance -= amount;
            }
        }
        public void GetBalance()
        {
            Console.WriteLine(Balance);
        }
    }
    public class InsufficientBalanceException: Exception
    {
        public InsufficientBalanceException(string message):base(message) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(300);
            account.Deposit(35.00);
            account.GetBalance();
            try
            {
                account.Withdraw(300.00);
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine(e.Message);
            }
            account.GetBalance();
            try
            {
                account.Withdraw(40.00);
            }
            catch(InsufficientBalanceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

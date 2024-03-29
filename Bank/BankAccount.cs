﻿using System;
namespace BankAccountNS
{
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;
        private BankAccount() { }
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }
        public string CustomerName
        {
            get { return m_customerName; }
        }
        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance -= amount; //incorrect code added
        }

        public void Credit(double amount)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance += amount;
        }
        public static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Mr. Walton", 12.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine($"Current balance is: {ba.Balance}");
        }
    }
}
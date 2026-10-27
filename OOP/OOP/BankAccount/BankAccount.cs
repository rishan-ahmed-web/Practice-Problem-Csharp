using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if(amount > 0)
                Balance += amount;
            else
                Console.WriteLine("Deposit not allowed");
        }

        public void Withdraw(double amount)
        {
            if(amount <= 0)
                Console.WriteLine("Invalid amount");
             if (amount > Balance)
                throw new InvalidOperationException("Insufficient balance");
            else
                Balance -= amount;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Account: {AccountHolder} Balance: {Balance}");
        }
    }
}

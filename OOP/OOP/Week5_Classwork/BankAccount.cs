using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week5_Classwork
{
    public class BankAccount
    {
        private int accountNumber;
        private double balance;

        public BankAccount()
        {
            this.Transactions = new List<string>();
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set { this.accountNumber = value; }
        }

        public string AccountHolder { get; set; }

        public double Balance
        {
            get { return balance; }
        }

        public List<string> Transactions { get; }

        public void Deposit(double amount)
        {
            this.balance += amount;
            this.Transactions.Add($"Deposited ${amount}");
        }

        public void Withdraw(double amount)
        {
            this.balance -= amount;
            this.Transactions.Add($"Withdrew ${amount}");
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public List<string> GetTransactions()
        {
            return this.Transactions;
        }
    }
}

/*
 * Create a BankAccount class that has the following public properties: 
- AccountNumber
- AccountHolder 
- Balance
- Transactions. 

The transactions property should be a list of strings that represent the history of transactions for the bank account.

The BankAccount class should have the following public methods:

- Deposit(amount): adds the specified amount to the account balance and adds a string to the transactions list in the following format: "Deposited $[amount]".
- Withdraw(amount): subtracts the specified amount from the account balance and adds a string to the transactions list in the following format: "Withdrew $[amount]".
- GetBalance(): returns the current balance of the account.
- GetTransactionHistory(): returns a list of strings representing the transaction history for the account.

The BankAccount class should also have the following public properties that allow the accountNumber and accountHolder properties to be accessed and modified:

AccountNumber: gets or sets the accountNumber property.
AccountHolder: gets or sets the accountHolder property.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProblems
{
    class EncapsulationBankAcc
    {
        private string accountHolder;
        private double balance;

        // Public property for account holder
        public string AccountHolder
        {
            get { return accountHolder; }
            set
            {
                // Add validation logic if needed
                accountHolder = value;
            }
        }

        // Public property for balance
        public double Balance
        {
            get { return balance; }
        }

        // Public method to deposit money
        public void Deposit(double amount)
        {
            // Add validation logic if needed
            balance += amount;
            Console.WriteLine($"{amount} deposited. New balance: {balance}");
        }

        // Public method to withdraw money
        public void Withdraw(double amount)
        {
            // Add validation logic if needed
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"{amount} withdrawn. New balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Q1
{
    class BankAccount
    {
        private int accountNumber;
        private string accountHolderName;
        private string accountType;
        private char transactionType;
        private double accountBalance;
        public BankAccount(int accountNumber, string accountHolderName, string accountType)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.accountType = accountType;
            this.accountBalance = 0;
        }
        public char TransactionType
        {
            get { return transactionType; }
            set
            {
                if (value == 'D' || value == 'W')
                {
                    transactionType = value;
                }
                else
                {
                    Console.WriteLine("Invalid. Select 'D'/'W'");
                }
            }

        }
        public double Amount { get; set; }
        public void Deposit()
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Invalid.");
                return;
            }
            accountBalance += Amount;
            Console.WriteLine($"Deposited amount {Amount}. Updated balance: {accountBalance}");
        }
        public void Withdraw()
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Invalid amount.");
                return;
            }
            if (Amount <= accountBalance)
            {
                accountBalance -= Amount;
                Console.WriteLine($"Withdrawn amount: {Amount}. Updated balance: {accountBalance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Holder Name: {accountHolderName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Transaction Type: {TransactionType}");
            Console.WriteLine($"Account Balance: {accountBalance}");
        }
    }
    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount(1033409, "Anshika", "SAVINGS");
            while (true)
            {
                Console.Write("Enter D/W: ");
                char transactionType = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (transactionType != 'D' && transactionType != 'W')
                {
                    break;
                }
                account.TransactionType = transactionType;
                Console.Write("Enter Amount: ");
                double amount;
                if (!double.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid.");
                    continue;
                }
                account.Amount = amount;
                if (account.TransactionType == 'D')
                {
                    account.Deposit();
                }
                else if (account.TransactionType == 'W')
                {
                    account.Withdraw();
                }
                account.DisplayAccountInfo();
            }
            Console.WriteLine("Transaction completed.");
            Console.ReadLine();
        }
    }
}

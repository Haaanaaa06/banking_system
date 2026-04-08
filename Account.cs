using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system
{
    abstract class Account
    {
        private string accountNumber;
        private string accountHolder;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            protected set { accountNumber = value; }
        }

        public string AccountHolder
        {
            get { return accountHolder; }
            protected set { accountHolder = value; }
        }

        public double Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }

        public Account(string accNum, string holder, double bal)
        {
            AccountNumber = accNum;
            AccountHolder = holder;
            Balance = bal;
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void CalculateInterest();

        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine($"Account: {AccountNumber}, Holder: {AccountHolder}");
            Console.WriteLine($"Balance: ${Balance:F2}");
        }

        public void Transfer(Account target, double amount)
        {
            Withdraw(amount);
            target.Deposit(amount);
            Console.WriteLine($"Transferred ${amount} to {target.AccountHolder}");
        }

        public void Transfer(Account target, double amount, string note)
        {
            Withdraw(amount);
            target.Deposit(amount);
            Console.WriteLine($"Transferred ${amount} to {target.AccountHolder} - {note}");
        }
    }
}


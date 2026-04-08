using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; private set; }

        public SavingsAccount(string accNum, string holder, double bal, double rate)
            : base(accNum, holder, bal)
        {
            InterestRate = rate;
        }

        // Override Abstract Methods
        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount} to savings account");
            }
            else
            {
                Console.WriteLine("Oooop your input invaild");
            }

        }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew ${amount} from savings account");
            }
            else
            {
                Console.WriteLine("Insufficient balance for withdrawal!");
            }
        }

        public override void CalculateInterest()
        {
            double interest = Balance * InterestRate / 100;
            Balance += interest;
            Console.WriteLine($"Interest calculated: ${interest:F2}. New balance: ${Balance:F2}");
        }

        // Override DisplayAccountInfo
        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Account Type: Savings, Interest Rate: {InterestRate}%");
        }
    }
}

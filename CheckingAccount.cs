using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system
{
    class CheckingAccount : Account
    {
        public double OverdraftLimit { get; private set; }

        public CheckingAccount(string accNum, string holder, double bal, double overdraft)
            : base(accNum, holder, bal)
        {
            OverdraftLimit = overdraft;
        }

        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount} to checking account");
            }
            else
            {
                Console.WriteLine("invaild");
            }

        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= -OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew ${amount} from checking account");
            }
            else
            {
                Console.WriteLine("Cannot withdraw, overdraft limit reached!");
            }
        }

        public override void CalculateInterest()
        {
            // No interest for checking accounts returns zero 
        }

        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Account Type: Checking, Overdraft Limit: ${OverdraftLimit:F2}");
        }
    }
}

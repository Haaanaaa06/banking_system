using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system
{
    class HighYieldSavings : SavingsAccount
    {
        private int withdrawalLimit;        //withdrawal limits per month
        private int withdrawCountThisMonth; // counts the withdraw per month

        public HighYieldSavings(string accNum, string holder, double bal, double rate, int limit)
            : base(accNum, holder, bal, rate)
        {
            withdrawalLimit = limit;
            withdrawCountThisMonth = 0;
        }

        // Override Withdraw with the limit 
        public override void Withdraw(double amount)
        {
            if (withdrawCountThisMonth < withdrawalLimit)
            {
                base.Withdraw(amount);  // (SavingsAccount)
                withdrawCountThisMonth++;
            }
            else
            {
                Console.WriteLine("Monthly withdrawal limit reached!");
            }
        }

        // Override DisplayAccountInfo 
        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Monthly Withdrawal Limit: {withdrawalLimit}, Withdrawals This Month: {withdrawCountThisMonth}");
        }
    }
}
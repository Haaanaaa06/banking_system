using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Banking System ===");


            SavingsAccount johnSavings = new SavingsAccount("SAV001", "John Doe", 1000, 2.5);
            johnSavings.DisplayAccountInfo();
            johnSavings.Deposit(100);
            johnSavings.Withdraw(50);
            johnSavings.CalculateInterest();
            Console.WriteLine();


            CheckingAccount janeChecking = new CheckingAccount("CHK001", "Jane Smith", 700, 200);
            janeChecking.DisplayAccountInfo();
            janeChecking.Withdraw(50);
            Console.WriteLine();

            johnSavings.Transfer(janeChecking, 50, "Monthly transfer");
            Console.WriteLine();


            HighYieldSavings highYield = new HighYieldSavings("HY001", "Alice Brown", 5000, 3.0, 2);
            highYield.DisplayAccountInfo();
            highYield.Withdraw(1000);
            highYield.Withdraw(500);
            highYield.Withdraw(100);
            highYield.CalculateInterest();
        }
    }

}

  
        
          
              

                    





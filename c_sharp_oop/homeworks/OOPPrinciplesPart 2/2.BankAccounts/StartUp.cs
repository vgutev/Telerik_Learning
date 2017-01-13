using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts
{
    class StartUp
    {
        static void Main()
        {
            Account[] bankAccounts =
            {
                new DepositAccount((Customer)1, 3000000, 3),
                new LoanAccount(Customer.Individual, 3000, 5),
                new MortgageAccount(Customer.Individual, 20000, 10)
            };

            foreach (Account account in bankAccounts)
            {
                Console.WriteLine("\n" + account.GetType().Name);
                Console.WriteLine("Interest for 1 month is: {0}", account.CalculateInterest(1));
                Console.WriteLine("Interest for 2 month is: {0}", account.CalculateInterest(2));
                Console.WriteLine("Interest for 5 month is: {0}", account.CalculateInterest(5));
                Console.WriteLine("Interest for 18 month is: {0}", account.CalculateInterest(18));
            }
        }
    }
}

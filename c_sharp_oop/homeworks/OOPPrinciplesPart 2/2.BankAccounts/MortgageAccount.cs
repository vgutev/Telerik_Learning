using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts
{
    public class MortgageAccount : Account, IDeposit
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public void Deposit(decimal money)
        {
            if (money > 0)
            {
                this.Balance += money;
            }
            else
            {
                throw new ArgumentException("Invalid amount of money entered!");
            }
        }
        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0M;
            decimal baseInterest = base.CalculateInterest(months);

            if (this.Customer == Customer.Individual)
            {
                if (months <7)
                {
                   interest = 0M;
                }
                else
                {
                    interest = baseInterest - (this.InterestRate * 6);
                }
            }
            if (this.Customer == Customer.Company && months < 13)
            {
                interest = baseInterest / 2;
            }
            else if (this.Customer == Customer.Company)
            {
                interest = baseInterest - (this.InterestRate * 12);
            }
            return interest;
        }
    }
}

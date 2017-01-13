using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts
{
    public class LoanAccount : Account, IDeposit
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
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
            decimal baseInterest = base.CalculateInterest(months);
            if (this.Customer == Customer.Individual && months > 3)
            {
                return baseInterest - (this.InterestRate * 3);
            }
            if (this.Customer == Customer.Company && months > 2)
            {
                return baseInterest - (this.InterestRate * 2);
            }
            return 0M;
        }
    }
}

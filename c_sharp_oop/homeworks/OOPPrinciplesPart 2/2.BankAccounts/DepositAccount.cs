using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts
{
    public class DepositAccount : Account, IDeposit, IWithdraw
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
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
        public void Withdraw(decimal money)
        {
            if (money > 0)
            {
                this.Balance -= money;
            }
            else
            {
                throw new ArgumentException("Invalid amount of money entered!");
            }
        }
        public override decimal CalculateInterest(int months)
        {
            decimal baseInterest = base.CalculateInterest(months);
            if (!(0 < this.Balance && this.Balance < 1000))
            {
                return baseInterest;
            }
            return 0M;
        }
    }
}

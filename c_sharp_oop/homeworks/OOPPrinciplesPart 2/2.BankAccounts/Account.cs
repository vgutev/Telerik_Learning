using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            private set
            {
                this.customer = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }
        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                this.interestRate = value;
            }
        }

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public virtual decimal CalculateInterest(int months)
        {
            if (months < 1)
            {
                throw new ArgumentException("Month must be positive number!");
            }
            decimal interest;
            interest = months * InterestRate;
            return interest;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Praticas2_A.Entities
{
    class BussinesAccount : Account
    {

        public double LoanLimit { get; set; }

        public BussinesAccount()
        {
        }

        public BussinesAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            //para não ter que refazer aqui tudo da Account a gente usa o :base(number, holder, balance)
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}

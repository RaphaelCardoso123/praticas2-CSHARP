using System;
using System.Collections.Generic;
using System.Text;

namespace Praticas2_A.Entities
{
    class SavingAccount : Account
    {

        public double InterestRate { get; set; }

        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            //para não ter que refazer aqui tudo da Account a gente usa o :base(number, holder, balance)
            InterestRate = InterestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}

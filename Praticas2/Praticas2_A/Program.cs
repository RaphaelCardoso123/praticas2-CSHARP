using System;
using Praticas2_A.Entities;
namespace Praticas2_A
{
    class Program
    {
        static void Main(string[] args)
        {
            // HERANÇA 
            //BussinesAccount account = new BussinesAccount(8000, "Raphael", 3500.00, 10000.00);
            //Console.WriteLine(account.Balance);


            // UPCASTING
            Account acc = new Account(8000, "Raphael", 0.0);
            BussinesAccount bacc = new BussinesAccount(7000, "Flávia", 0.0, 4500.00);

            Account acc1 = bacc;
            Account acc2 = new BussinesAccount(6000, "Júlia", 0.0, 3000.00);
            Account acc3 = new SavingAccount(500, "Kelly", 0.0, 0.01);


            // DOWNCASTING
            BussinesAccount acc4 = (BussinesAccount)acc2;
            acc4.Loan(100.00);


            // IS / AS
            if(acc3 is BussinesAccount)
            {
                //BussinesAccount acc5 = (BussinesAccount)acc3; //IS
                BussinesAccount acc5 = acc3 as BussinesAccount; //AS
                acc5.Loan(200.00);
                Console.WriteLine("Loan!!");
            }
            if(acc3 is SavingAccount)
            {
                //SavingAccount acc5 = (SavingAccount)acc3; //IS
                SavingAccount acc5 = acc3 as SavingAccount; //AS
                acc5.UpdateBalance();
                Console.WriteLine("Update!!");
            }




            Console.ReadLine();
        }
    }
}

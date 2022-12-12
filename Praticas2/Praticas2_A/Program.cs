using System;
using Praticas2_A.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Praticas2_A
{
    class Program
    {
        static void Main(string[] args)
        {

        // HERANÇA / UPCASTING / DOWNCASTING / IS / AS / SOBREPOSIÇÃO(SOBREESCRITA) VIRTUAL - OVERRIDE / BASE / CLASSE ABSTRATA

        List<Account> list = new List<Account>();

        list.Add(new SavingAccount(1001, "Alex", 500.00, 0.01));
        list.Add(new BussinesAccount(1002, "Maria", 500.00, 400.00));
        list.Add(new SavingAccount(1003, "Bob", 500.00, 0.01));
        list.Add(new BussinesAccount(1004, "Anna", 500.00, 500.00));


        double sum = 0.0;
        foreach (Account acc in list)
            {
                sum += acc.Balance;
            }
        Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));


        foreach (Account acc in list)
            {
                acc.Withdraw(10.00);
            }
        foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account " + acc.Number + ") " 
                + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }





            /*

            // HERANÇA / UPCASTING / DOWNCASTING / IS / AS / SOBREPOSIÇÃO(SOBREESCRITA) VIRTUAL - OVERRIDE / BASE

            // SOBREPOSIÇÃO(SOBREESCRITA) VIRTUAL - OVERRIDE
            Account acc1 = new Account(800, "Raphael", 4000.00);
            Account acc2 = new SavingAccount(700, "Flávia", 3000.00, 0.01);

            acc1.Withdraw(10.00);
            acc2.Withdraw(10.00);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            */





            /*

            // HERANÇA / UPCASTING / DOWNCASTING / IS / AS
            //BussinesAccount account = new BussinesAccount(8000, "Raphael", 3500.00, 10000.00);
            //Console.WriteLine(account.Balance);


            Account acc = new Account(8000, "Raphael", 0.0); // NORMAL
            BussinesAccount bacc = new BussinesAccount(7000, "Flávia", 0.0, 4500.00); // UPCASTING

            Account acc1 = bacc; // UPCASTING
            Account acc2 = new BussinesAccount(6000, "Júlia", 0.0, 3000.00); // UPCASTING
            Account acc3 = new SavingAccount(500, "Kelly", 0.0, 0.01); // UPCASTING

            
            BussinesAccount acc4 = (BussinesAccount)acc2; //DOWNCASTING
            acc4.Loan(100.00);


            
            if(acc3 is BussinesAccount)
            {
                //BussinesAccount acc5 = (BussinesAccount)acc3; // DOWNCASTING
                BussinesAccount acc5 = acc3 as BussinesAccount; // AS
                acc5.Loan(200.00);
                Console.WriteLine("Loan!!");
            }
            if(acc3 is SavingAccount)
            {
                //SavingAccount acc5 = (SavingAccount)acc3; // DOWNCASTING
                SavingAccount acc5 = acc3 as SavingAccount; // AS
                acc5.UpdateBalance();
                Console.WriteLine("Update!!");
            }

            */


            Console.ReadLine();
        }
    }
}

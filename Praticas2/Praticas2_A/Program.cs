using System;
using Praticas2_A.Entities;
namespace Praticas2_A
{
    class Program
    {
        static void Main(string[] args)
        {

            BussinesAccount account = new BussinesAccount(8000, "Raphael", 3500.00, 10000.00);
            Console.WriteLine(account.Balance);

            Console.ReadLine();

        }
    }
}

using SegundoProjeto.Entities;
using SegundoProjeto.Entities.Enums;
using System;

namespace SegundoProjeto 
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {

                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };

            Console.WriteLine(order);
        }
    }
}
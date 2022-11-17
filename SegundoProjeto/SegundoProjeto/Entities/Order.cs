using SegundoProjeto.Entities.Enums;
using System;

namespace SegundoProjeto.Entities
{
    class Order
    {

        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", 0" + Moment + ", " + Status;
        }

    }
}

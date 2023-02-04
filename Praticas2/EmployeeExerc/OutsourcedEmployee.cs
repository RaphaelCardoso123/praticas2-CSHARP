﻿
namespace Praticas2_C
{
    class OutsourcedEmployee : Employee
    {

        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base (name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }

    }
}

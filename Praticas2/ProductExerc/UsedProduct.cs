﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductExerc
{
    class UsedProduct : Product
    {

        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag();
        }

    }
}

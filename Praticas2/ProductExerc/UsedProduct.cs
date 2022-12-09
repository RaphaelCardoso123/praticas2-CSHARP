using System;
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

        public UsedProduct(DateTime manufactureDate)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag();
        }

    }
}

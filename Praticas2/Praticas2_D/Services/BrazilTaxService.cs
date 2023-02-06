
namespace Praticas2_D.Services
{
<<<<<<< HEAD
    class BrazilTaxService
=======
    class BrazilTaxService : ITaxService
>>>>>>> 4e65a0c92a9e7b2655ae58ccaf89dae5bee28522
    {

        public double Tax (double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }

    }
}

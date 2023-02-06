using System;


namespace Praticas2_D.Services
{
    class RentalService
    {

        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

<<<<<<< HEAD
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
=======
        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
>>>>>>> 4e65a0c92a9e7b2655ae58ccaf89dae5bee28522
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

<<<<<<< HEAD
            double tax = _brazilTaxService.Tax(basicPayment);
=======
            double tax = _taxService.Tax(basicPayment);
>>>>>>> 4e65a0c92a9e7b2655ae58ccaf89dae5bee28522

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}

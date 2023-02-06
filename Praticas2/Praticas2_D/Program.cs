using System;
using System.Globalization;
using Praticas2_D.Services;

namespace Praticas2_D
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter rental date");

            Console.Write("Car model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
<<<<<<< HEAD

=======
>>>>>>> 4e65a0c92a9e7b2655ae58ccaf89dae5bee28522
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

<<<<<<< HEAD
            RentalService rentalService = new RentalService(hour, day);
=======
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
>>>>>>> 4e65a0c92a9e7b2655ae58ccaf89dae5bee28522

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice:");
            Console.WriteLine(carRental.Invoice);
<<<<<<< HEAD
=======

            Console.ReadLine();
>>>>>>> 4e65a0c92a9e7b2655ae58ccaf89dae5bee28522
        }
    }
}

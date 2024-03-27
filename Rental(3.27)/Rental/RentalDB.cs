using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Rental
{
    public class RentalDB
    {
        public List<Car> Car { get; }
        private List<Rental> rentals = new List<Rental>();

        public RentalDB()
        {
            Car = new List<Car>
            {
                new Car("01", "Accord-Honda-2019-$22,500-Used", true),
                new Car("02", "Mustang-Ford-2022-$35,000-New", true),
                new Car("03", "Camry-Toyota-2017-$18,000-Used", true),
                new Car("04", "Sonata-Hyundai-2020-$25,500-Certified Pre-owned", true),
                new Car("05", "Wrangler-Jeep-2018-$28,000-Used", true)
            };
        }

        public void AddRental(Rental rental)
        {
            rentals.Add(rental);
        }

        public List<string> ValidateRentalData(string customerID, string carID, DateTime startDate, DateTime endDate, ListBox lbxCarList)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(customerID))
            {
                errors.Add("Please enter Customer ID.");
            }

            if (string.IsNullOrWhiteSpace(carID))
            {
                errors.Add("Please enter Vehicle ID.");
            }

            if (startDate == DateTime.MinValue)
            {
                errors.Add("Please select Start Date.");
            }

            if (endDate == DateTime.MinValue)
            {
                errors.Add("Please select End Date.");
            }

            string pattern = @"^[A-Za-z0-9]+$";
            if (!Regex.IsMatch(customerID, pattern))
            {
                errors.Add("Customer ID format is incorrect. Please check and re-enter.");
            }

            if (!Regex.IsMatch(carID, pattern))
            {
                errors.Add("Vehicle ID format is incorrect. Please check and re-enter.");
            }

            if (startDate >= endDate)
            {
                errors.Add("End Date must be later than Start Date.");
            }

            return errors;
        }

        public bool RentCar(string customerID, string carID, DateTime startDate, DateTime endDate, int rentalID)
        {
            var car = Car.FirstOrDefault(c => c.CarID == carID && c.IsAvailable);
            if (car != null)
            {
                car.IsAvailable = false;
                rentals.Add(new Rental(rentalID, carID, startDate, endDate));
                return true;
            }
            return false;
        }

        public List<Rental> GetAllRentals()
        {
            return rentals;
        }

        public List<Car> GetAllAvailableCars()
        {
            return Car.Where(car => car.IsAvailable).ToList();
        }

        public bool IsCarAvailable(string carId)
        {
            return Car.Any(c => c.CarID == carId && c.IsAvailable);
        }

        public bool ReturnCar(string carID, string customerID)
        {
            var rental = rentals.FirstOrDefault(r => r.CarID == carID && !r.IsReturned);
            if (rental == null)
            {
                return false;
            }

            rental.IsReturned = true;
            var car = Car.FirstOrDefault(c => c.CarID == carID);
            if (car != null)
            {
                car.IsAvailable = true;
            }

            return true;
        }
    }
}

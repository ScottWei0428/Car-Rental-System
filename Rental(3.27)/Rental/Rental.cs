using System;

namespace Rental
{
    public class Rental
    {
        public int RentalID { get; set; }
        public string CarID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsReturned { get; set; } = false;
        public Rental(int rentalID, string carID, DateTime startDate, DateTime endDate)
        {
            RentalID = rentalID;
            CarID = carID;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}

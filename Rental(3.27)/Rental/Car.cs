using System.Windows.Forms;

namespace Rental
{
    public class Car
    {
        internal ListViewItem.ListViewSubItem status;

        public string CarID { get; set; }
        public string Details { get; set; }
        public bool IsAvailable { get; set; }

        public Car(string carID, string details, bool isAvailable)
        {
            CarID = carID;
            Details = details;
            IsAvailable = isAvailable;
        }
    }
}

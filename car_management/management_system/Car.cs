using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management_system
{
    internal class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
        public String Status { get; set; }
        public string CarID { get; set; }

        public Car(string model, string brand, string year, string price, string status, string carid)
        {
            Model = model; Brand = brand; Year = year; Price = price; Status = status;CarID = carid ;
        }
    }
}

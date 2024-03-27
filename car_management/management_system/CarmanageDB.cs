using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace management_system
{
    internal static class CarmanageDB
    {
        private static readonly string FilePath = @"C:\Users\79457\Desktop\Application Dev ITE-5230-IRA\Car Rental System0327\car_management\management_system\car_details.txt";
        private const string Delimiter = "|";

        // Method to retrieve car details from the text file
        public static List<Car> GetCars()
        {
            List<Car> cars = new List<Car>();

            using (StreamReader textIn = new StreamReader(new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                string row;
                while ((row = textIn.ReadLine()) != null)
                {
                    string[] columns = row.Split(Delimiter.ToCharArray());

                    if (columns.Length == 6) // Ensure all fields are present
                    {
                        Car car = new Car(columns[0], columns[1], columns[2], columns[3], columns[4], columns[5]); // Provide all parameters
                        cars.Add(car);
                    }
                }
            }
            return cars;
        }

        // Method to save car details to the text file
        public static void SaveCars(List<Car> cars)
        {
            using (StreamWriter textOut = new StreamWriter(new FileStream(FilePath, FileMode.Create, FileAccess.Write)))
            {
                foreach (Car car in cars)
                {
                    textOut.Write(car.Model + Delimiter);
                    textOut.Write(car.Brand + Delimiter);
                    textOut.Write(car.Year + Delimiter);
                    textOut.Write(car.Price + Delimiter);
                    textOut.Write(car.Status + Delimiter);
                    textOut.WriteLine(car.CarID);
                }
            }
        }

        // Method to add a new car to the database
        public static bool AddCar(string model, string brand, string year, string price, string status, string carid, out string errorMessage)
        {
            errorMessage = null;

            // Validate input
            if (!IsValidInput(model, brand, year, price, status, carid))
            {
                errorMessage = "Invalid car information.";
                return false;
            }

            try
            {
                // Create a new Car object and add it to the list
                List<Car> cars = GetCars();
                Car newCar = new Car(model, brand, year, price, status, carid);
                cars.Add(newCar);
                SaveCars(cars);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = "An error occurred while adding the car: " + ex.Message;
                return false;
            }
        }

        // Method to update an existing car in the database
        public static bool UpdateCar(int index, string model, string brand, string year, string price, string status, string carid, out string errorMessage)
        {
            errorMessage = null;

            // Check if the index is valid
            if (index < 0 || index >= GetCars().Count)
            {
                errorMessage = "Index is out of range.";
                return false;
            }

            // Validate input
            if (!IsValidInput(model, brand, year, price, status, carid))
            {
                errorMessage = "Invalid car information.";
                return false;
            }

            // Update the car at the specified index
            List<Car> cars = GetCars();
            cars[index] = new Car(model, brand, year, price, status, carid);
            SaveCars(cars);
            return true;
        }

        // Method to remove a car from the database
        public static bool RemoveCar(int index, out string errorMessage)
        {
            errorMessage = null;

            // Check if the index is valid
            if (index < 0 || index >= GetCars().Count)
            {
                errorMessage = "Index is out of range.";
                return false;
            }

            // Remove the car at the specified index
            List<Car> cars = GetCars();
            cars.RemoveAt(index);
            SaveCars(cars);
            return true;
        }

        // Method to view details of a car
        public static bool ViewCar(int index, out Car car, out string errorMessage)
        {
            errorMessage = null;
            car = null;

            // Check if the index is valid
            if (index < 0 || index >= GetCars().Count)
            {
                errorMessage = "Index is out of range.";
                return false;
            }

            // Retrieve the car at the specified index
            car = GetCars()[index];
            return true;
        }

        // Method to validate input fields
        private static bool IsValidInput(string model, string brand, string year, string price, string status, string carid)
        {
            // Check for null or empty values and validate numeric fields
            if (string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(status) || !int.TryParse(year, out _) || !double.TryParse(price, out _) || !int.TryParse(carid, out _))
                return false;

            // Regular expressions to validate model, brand, and status
            Regex modelRegex = new Regex("^[\\w .,-]*$");
            Regex brandRegex = new Regex("^[\\w .,-]*$");
            Regex statusRegex = new Regex("^[\\w .,-]*$");
            Regex yearRegex = new Regex("^[0-9-]*$");
            Regex priceRegex = new Regex("^[0-9.]*$");
            Regex idRegex = new Regex("^[0-9]*$");

            // Check if model, brand, and status match the regex patterns
            if (!modelRegex.IsMatch(model) || !brandRegex.IsMatch(brand) || !statusRegex.IsMatch(status))
                return false;

            // Check if year and price match the regex patterns
            return yearRegex.IsMatch(year) && priceRegex.IsMatch(price) && idRegex.IsMatch(carid);
        }
    }
}

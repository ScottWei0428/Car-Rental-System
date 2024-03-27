using CustomerManagementApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CustomerManagementProject
{
    public static class CustomerDB
    {
        private static readonly string FilePath = @"C:\Users\79457\Desktop\Application Dev ITE-5230-IRA\Car Rental System0327\customerProject\CustomerManagementApp\customer.txt";
        private const string Delimiter = "|";

        // Method to retrieve customer details from the text file
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (StreamReader textIn = new StreamReader(new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                string row;
                while ((row = textIn.ReadLine()) != null)
                {
                    string[] columns = row.Split(Delimiter.ToCharArray());

                    if (columns.Length == 5) // Ensure all fields are present
                    {
                        Customer customer = new Customer(Convert.ToInt32(columns[0]), columns[1],
                        columns[2], columns[3], columns[4]); // Provide all parameters
                        customers.Add(customer);
                    }
                }
            }
            return customers;
        }

        // Method to save customer details to the text file
        public static void SaveCustomers(List<Customer> customers)
        {
            using (StreamWriter textOut = new StreamWriter(new FileStream(FilePath, FileMode.Create, FileAccess.Write)))
            {
                foreach (Customer customer in customers)
                {
                    textOut.WriteLine(customerToFileString(customer));
                }
            }
        }

        // Method to add a new customer to the database
        public static bool AddCustomer(int id, string name, string address, string phoneNumber, string email, out string errorMessage)
        {
            errorMessage = null;

            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(email))
            {
                errorMessage = "Please fill all the fields.";
                return false;
            }

            // Check if ID is duplicate
            if (IsDuplicateId(id))
            {
                errorMessage = "Customer ID already exists. Please choose a different ID.";
                return false;
            }

            // Validate Name
            if (!IsValidName(name))
            {
                errorMessage = "Invalid name format. Name should contain only characters.";
                return false;
            }

            // Validate Phone Number
            if (!IsValidPhoneNumber(phoneNumber))
            {
                errorMessage = "Invalid phone number format. Phone number should contain only numbers.";
                return false;
            }

            // Validate Email
            if (!IsValidEmail(email))
            {
                errorMessage = "Invalid email format.";
                return false;
            }

            try
            {
                // All data is valid, add customer to the database
                List<Customer> customers = GetCustomers();
                customers.Add(new Customer(id, name, address, phoneNumber, email));
                SaveCustomers(customers);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = "An error occurred while adding the customer: " + ex.Message;
                return false;
            }
        }

        // Method to update an existing customer in the database
        public static bool UpdateCustomer(int customerId, string name, string address, string phoneNumber, string email, out string errorMessage)
        {
            errorMessage = "";

            List<Customer> customers = GetCustomers();

            // Find the customer with the given ID
            Customer customerToUpdate = customers.Find(c => c.Id == customerId);

            if (customerToUpdate != null)
            {
                // Check if the details are the same as the existing customer details
                if (customerToUpdate.Name == name &&
                    customerToUpdate.Address == address &&
                    customerToUpdate.PhoneNumber == phoneNumber &&
                    customerToUpdate.Email == email)
                {
                    // If there are no changes, display a message box and return false
                    MessageBox.Show("There are no changes to update.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                // Validate Name
                if (string.IsNullOrWhiteSpace(name) || !IsValidName(name))
                {
                    errorMessage = "Invalid name format. Name should contain only characters.";
                    return false;
                }

                // Validate Phone Number
                if (string.IsNullOrWhiteSpace(phoneNumber) || !IsValidPhoneNumber(phoneNumber))
                {
                    errorMessage = "Invalid phone number format. Phone number should contain only numbers.";
                    return false;
                }

                // Validate Email
                if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
                {
                    errorMessage = "Invalid email format.";
                    return false;
                }

                // Check if the updated details belong to another customer
                if (IsDuplicate(customerId, name, address, phoneNumber, email))
                {
                    errorMessage = "Customer details already exist for another customer.";
                    return false;
                }

                // Update customer's information
                customerToUpdate.Name = name;
                customerToUpdate.Address = address;
                customerToUpdate.PhoneNumber = phoneNumber;
                customerToUpdate.Email = email;

                // Save the updated list of customers
                SaveCustomers(customers);
                return true;
            }

            errorMessage = "Customer not found.";
            return false;
        }

       
        // Method to remove a customer from the database
        public static bool DeleteCustomer(int id, out string errorMessage)
        {
            errorMessage = null;

            string message = "Are you sure you want to delete this customer?";
            string caption = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                // Get the list of customers
                List<Customer> customers = GetCustomers();

                // Find the customer with the given ID
                Customer customerToDelete = customers.FirstOrDefault(c => c.Id == id);

                if (customerToDelete != null)
                {
                    // Remove the customer from the list
                    customers.Remove(customerToDelete);

                    // Save the updated list of customers
                    SaveCustomers(customers);

                    return true; // Deletion successful
                }
                else
                {
                    errorMessage = "Customer not found.";
                    return false; // Customer not found
                }
            }
            else
            {
                errorMessage = "Customer deletion canceled.";
                return false; // User canceled deletion
            }
        }


        // Method to view details of a customer
        public static bool ViewCustomer(int id, out Customer customer, out string errorMessage)
        {
            errorMessage = null;
            customer = GetCustomers().FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                errorMessage = "Customer not found.";
                return false;
            }
            return true;
        }

        // Method to check if details already exist for another customer
        private static bool IsDuplicate(int customerId, string name, string address, string phoneNumber, string email)
        {
            List<Customer> customers = GetCustomers();

            foreach (Customer customer in customers)
            {
                if (customer.Id != customerId &&
                    (customer.Name.Equals(name) || customer.Address.Equals(address) ||
                     customer.PhoneNumber.Equals(phoneNumber) || customer.Email.Equals(email)))
                {
                    return true;
                }
            }
            return false;
        }
       
       
        private static bool IsValidEmail(string email)
        {
            // Regular expression pattern for basic email validation
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        // Method to validate phone number using regular expression
        private static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regular expression pattern for basic phone number validation
            string pattern = @"^[0-9]+$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        // Method to validate name - allow only alphabets and spaces
        private static bool IsValidName(string name)
        {
            // Regular expression pattern to allow only alphabets and spaces
            string pattern = @"^[a-zA-Z\s]+$";
            return Regex.IsMatch(name, pattern);
        }

        // Method to check if a given ID already exists in the database
        private static bool IsDuplicateId(int id)
        {
            List<Customer> customers = GetCustomers();
            return customers.Any(c => c.Id == id);
        }
        // Method to convert Customer object to a string to be written to file
        private static string customerToFileString(Customer customer)
        {
            return $"{customer.Id}{Delimiter}{customer.Name}{Delimiter}{customer.Address}" +
                $"{Delimiter}{customer.PhoneNumber}{Delimiter}{customer.Email}";
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementApp
{
    // Class representing a customer
    public class Customer
    {
        // Properties for customer details
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // Constructor
        public Customer(int id, string name, string address, string phoneNumber, string email)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        // Default constructor
        public Customer()
        {
            // Default constructor
        }

        // Override ToString method to return string representation of Customer
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Address: {Address}, Phone Number: {PhoneNumber}, Email: {Email}";
        }
    }
}







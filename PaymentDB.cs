using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Car_Rental_System
{
    internal class PaymentDB
    {
        private List<PaymentInfo> payments = new List<PaymentInfo>();
        private static readonly string FilePath = @"C:\Users\79457\Desktop\Application Dev ITE-5230-IRA\Car Rental System0327\paymentRecord.txt";
        private const char Delimiter = '|'; 

        public PaymentDB()
        {
            LoadPayments(); 
        }

        public void AddPayment(PaymentInfo payment)
        {
            if (!CheckRentalIDExists(payment.RentalID))
            {
                payments.Add(payment);
                SavePayments(); 
            }
        }

        public bool CheckRentalIDExists(string rentalID)
        {
            return payments.Any(p => p.RentalID == rentalID);
        }

        public void DeletePaymentByRentalID(string rentalID)
        {
         
            var paymentToRemove = payments.FirstOrDefault(p => p.RentalID == rentalID);
            if (paymentToRemove != null)
            {
                payments.Remove(paymentToRemove);
                
                SavePayments();
            }
        }

        public List<PaymentInfo> GetPayments()
        {
            return new List<PaymentInfo>(payments); 
        }

        public void LoadPayments()
        {
            payments.Clear();
            if (File.Exists(FilePath))
            {
                using (var reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(Delimiter);
                        if (parts.Length == 4 &&
                            decimal.TryParse(parts[1], out decimal amount) &&
                            DateTime.TryParse(parts[2], out DateTime date))
                        {
                            payments.Add(new PaymentInfo
                            {
                                RentalID = parts[0],
                                Amount = amount,
                                Date = date,
                                Method = parts[3]
                            });
                        }
                    }
                }
            }
        }

       
        
        public void SavePayments()
        {
            try
            {
                using (var textOut = new StreamWriter(FilePath, false))
                {
                    foreach (var payment in payments)
                    {
                        textOut.WriteLine($"{payment.RentalID}{Delimiter}{payment.Amount}{Delimiter}{payment.Date:yyyy-MM-dd}{Delimiter}{payment.Method}");
                    }
                }
            }
            catch (Exception ex)
            {    
                Console.WriteLine($"Failed to save payments: {ex.Message}");
            }
        }
    }
}

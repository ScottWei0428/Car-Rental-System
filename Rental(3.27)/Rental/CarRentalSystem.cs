using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Rental
{
    public partial class CarRentalSystem : Form
    {
        private RentalDB rentalDB;
        private Dictionary<Control, ErrorProvider> errorProviders;

        public CarRentalSystem()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.CarRentalSystemimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.MouseClick += Form1_MouseClick;

            rentalDB = new RentalDB();
            errorProviders = new Dictionary<Control, ErrorProvider> {
            { tbxCustomerID, new ErrorProvider() },
            { tbxCarID, new ErrorProvider() },
            { dtpEndDate, new ErrorProvider() },
            { dtpStartDate, new ErrorProvider() },
            { tbxRentalID, new ErrorProvider() }
        };

            LSVStatus.Columns.Add("Cars", -2, HorizontalAlignment.Left);
            LSVStatus.Columns.Add("Status", -2, HorizontalAlignment.Left);
            LSVStatus.Columns.Add("Details", -2, HorizontalAlignment.Left);

            PopulateCarList();
            UpdateCarStatusListView();
        }

        private void UpdateCarStatusListView()
        {
            LSVStatus.Items.Clear();
            foreach (var car in rentalDB.Car)
            {
                var item = new ListViewItem(car.CarID);
                item.SubItems.Add(car.Details);
                string status = car.IsAvailable ? "Available" : "Unavailable";
                item.SubItems.Add(status);

                LSVStatus.Items.Add(item);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!tbxCustomerID.Bounds.Contains(e.Location) && !tbxCarID.Bounds.Contains(e.Location))
            {
                lbxCarList.ClearSelected();
            }
            this.Focus();
        }

        private void btnRentCar_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Invalid Information. Please review your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbxRentalID.Text, out int rentalID))
            {
                MessageBox.Show("Invalid Rental ID. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerID = tbxCustomerID.Text;
            string carID = tbxCarID.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            bool success = rentalDB.RentCar(customerID, carID, startDate, endDate, rentalID);
            if (success)
            {
                MessageBox.Show("Car rental successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string rentalInfo = $"Rented | Rental ID: {rentalID}, Car ID: {carID}, Customer ID: {customerID}, Start: {startDate.ToShortDateString()}, End: {endDate.ToShortDateString()}";
                lbxInfo.Items.Add(rentalInfo);
                PopulateCarList();
                UpdateCarStatusListView();
            }
            else
            {
                MessageBox.Show($"The selected car ({carID}) has already been rented out.", "Car Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateCarStatusListView();
        }

        private bool ValidateInput()
        {
            bool isValid = true;


            if (string.IsNullOrWhiteSpace(tbxCustomerID.Text))
            {
                errorProviders[tbxCustomerID].SetError(tbxCustomerID, "Please enter Customer ID.");
                isValid = false;
            }
            else
            {
                errorProviders[tbxCustomerID].SetError(tbxCustomerID, "");
            }

            if (string.IsNullOrWhiteSpace(tbxCarID.Text))
            {
                errorProviders[tbxCarID].SetError(tbxCarID, "Please enter Vehicle ID.");
                isValid = false;
            }
            else
            {
                errorProviders[tbxCarID].SetError(tbxCarID, "");
            }

            if (dtpEndDate.Value <= dtpStartDate.Value)
            {
                errorProviders[dtpEndDate].SetError(dtpEndDate, "End Date must be later than Start Date.");
                isValid = false;
            }
            else
            {
                errorProviders[dtpEndDate].SetError(dtpEndDate, "");
            }

            if (dtpStartDate.Value == DateTime.MinValue)
            {
                errorProviders[dtpStartDate].SetError(dtpStartDate, "Please select Start Date.");
                isValid = false;
            }
            else
            {
                errorProviders[dtpStartDate].SetError(dtpStartDate, "");
            }

            if (string.IsNullOrWhiteSpace(tbxRentalID.Text))
            {
                errorProviders[tbxRentalID].SetError(tbxRentalID, "Please enter Rental ID.");
                isValid = false;
            }
            else
            {
                errorProviders[tbxRentalID].SetError(tbxRentalID, "");
            }
            return isValid;
        }


   
        private void tbxCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCarID_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbxCarID.Text.Trim().ToLower();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var matchingCar = rentalDB.Car.FirstOrDefault(car => car.CarID.ToLower().Equals(searchText));
                lbxCarList.Items.Clear();
                if (matchingCar != null)
                {

                    lbxCarList.Items.Add($"{matchingCar.Details} - {matchingCar.CarID}");
                }
            }
            else
            {

                PopulateCarList();
            }
        }
        private void PopulateCarList()
        {
            lbxCarList.Items.Clear();
            foreach (var car in rentalDB.Car)
            {

                lbxCarList.Items.Add($"{car.Details} - {car.CarID}");
            }
        }
        private void lblCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void lblCarID_Click(object sender, EventArgs e)
        {

        }

        private void lblStartDate_Click(object sender, EventArgs e)
        {

        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {

        }
        private void lbxCarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxCarList.SelectedItem != null)
            {
                string selectedCar = lbxCarList.SelectedItem.ToString();
                string carId = GetCarId(selectedCar);
                tbxCarID.Text = carId;

                string carInfo = GetCarInfo(selectedCar);
                lbxVehicleInformation.Items.Clear();
                lbxVehicleInformation.Items.Add(carInfo);
            }
        }

        private string GetCarInfo(string car)
        {
            string[] carParts = car.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            string carName = carParts[0].Trim();
            string brand = carParts[1].Trim();
            string year = carParts[2].Trim();
            string price = carParts[3].Trim();
            string status = carParts[4].Trim();
            string carId = GetCarId(carName);

            return $"Model: {carName}, Brand: {brand}, Year: {year}, Price: {price}, Status: {status}, CarID: {carId}";
        }

        private string GetCarId(string carInfo)
        {
            string[] carParts = carInfo.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            string carName = carParts[0].Trim();

            switch (carName)
            {
                case "Accord":
                    return "01";
                case "Mustang":
                    return "02";
                case "Camry":
                    return "03";
                case "Sonata":
                    return "04";
                case "Wrangler":
                    return "05";
                default:
                    return "Unknown";
            }
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            string carID = tbxCarID.Text;
            string customerID = tbxCustomerID.Text;
            int rentalID = FindRentalIDByCarID(carID);

            bool success = rentalDB.ReturnCar(carID, customerID);
            if (success)
            {
                MessageBox.Show("Car returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string returnInfo = $"Returned | Rental ID: {rentalID}, Car ID: {carID}, Customer ID: {customerID}";
                lbxInfo.Items.Add(returnInfo);
                UpdateCarStatusListView();
                PopulateCarList();
            }
            else
            {
                MessageBox.Show("Unable to return the car. It may not be rented out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private int FindRentalIDByCarID(string carID)
        {
            return 0;
        }


        private void dtpStartDate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dtpEndDate_ValueChanged_1(object sender, EventArgs e)
        {
        }

        private void lblPopularmodels_Click(object sender, EventArgs e)
        {

        }
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblVehicleInformation_Click(object sender, EventArgs e)
        {

        }

        private void lbxVehicleInformation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LSVStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRentalID_Click(object sender, EventArgs e)
        {

        }

        private void tbxRentalID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


namespace Rental
{
    partial class CarRentalSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCarID = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblPopularmodels = new System.Windows.Forms.Label();
            this.tbxCustomerID = new System.Windows.Forms.TextBox();
            this.tbxCarID = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbxCarList = new System.Windows.Forms.ListBox();
            this.btnRentCar = new System.Windows.Forms.Button();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.lblVehicleInformation = new System.Windows.Forms.Label();
            this.lbxVehicleInformation = new System.Windows.Forms.ListBox();
            this.LSVStatus = new System.Windows.Forms.ListView();
            this.LVStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRentalID = new System.Windows.Forms.Label();
            this.tbxRentalID = new System.Windows.Forms.TextBox();
            this.lbxInfo = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 34);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(98, 18);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "CustomerID";
            this.lblCustomerID.Click += new System.EventHandler(this.lblCustomerID_Click);
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblCarID.Location = new System.Drawing.Point(39, 79);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(53, 18);
            this.lblCarID.TabIndex = 1;
            this.lblCarID.Text = "CarID";
            this.lblCarID.Click += new System.EventHandler(this.lblCarID_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblStartDate.Location = new System.Drawing.Point(21, 175);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(89, 18);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "StartDate";
            this.lblStartDate.Click += new System.EventHandler(this.lblStartDate_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblEndDate.Location = new System.Drawing.Point(30, 232);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(71, 18);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "EndDate";
            this.lblEndDate.Click += new System.EventHandler(this.lblEndDate_Click);
            // 
            // lblPopularmodels
            // 
            this.lblPopularmodels.AutoSize = true;
            this.lblPopularmodels.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblPopularmodels.Location = new System.Drawing.Point(12, 305);
            this.lblPopularmodels.Name = "lblPopularmodels";
            this.lblPopularmodels.Size = new System.Drawing.Size(125, 18);
            this.lblPopularmodels.TabIndex = 4;
            this.lblPopularmodels.Text = "Popularmodels";
            this.lblPopularmodels.Click += new System.EventHandler(this.lblPopularmodels_Click);
            // 
            // tbxCustomerID
            // 
            this.tbxCustomerID.Location = new System.Drawing.Point(135, 30);
            this.tbxCustomerID.Name = "tbxCustomerID";
            this.tbxCustomerID.Size = new System.Drawing.Size(175, 28);
            this.tbxCustomerID.TabIndex = 5;
            this.tbxCustomerID.TextChanged += new System.EventHandler(this.tbxCustomerID_TextChanged);
            // 
            // tbxCarID
            // 
            this.tbxCarID.Location = new System.Drawing.Point(135, 76);
            this.tbxCarID.Name = "tbxCarID";
            this.tbxCarID.Size = new System.Drawing.Size(175, 28);
            this.tbxCarID.TabIndex = 6;
            this.tbxCarID.TextChanged += new System.EventHandler(this.tbxCarID_TextChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(135, 168);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(175, 28);
            this.dtpStartDate.TabIndex = 7;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(135, 225);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(175, 28);
            this.dtpEndDate.TabIndex = 8;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lbxCarList
            // 
            this.lbxCarList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbxCarList.FormattingEnabled = true;
            this.lbxCarList.ItemHeight = 18;
            this.lbxCarList.Location = new System.Drawing.Point(12, 339);
            this.lbxCarList.Name = "lbxCarList";
            this.lbxCarList.Size = new System.Drawing.Size(298, 238);
            this.lbxCarList.TabIndex = 9;
            this.lbxCarList.SelectedIndexChanged += new System.EventHandler(this.lbxCarList_SelectedIndexChanged);
            // 
            // btnRentCar
            // 
            this.btnRentCar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnRentCar.Location = new System.Drawing.Point(12, 581);
            this.btnRentCar.Name = "btnRentCar";
            this.btnRentCar.Size = new System.Drawing.Size(123, 34);
            this.btnRentCar.TabIndex = 10;
            this.btnRentCar.Text = "RentCar";
            this.btnRentCar.UseVisualStyleBackColor = false;
            this.btnRentCar.Click += new System.EventHandler(this.btnRentCar_Click);
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.BackColor = System.Drawing.Color.Azure;
            this.btnReturnCar.Location = new System.Drawing.Point(187, 581);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(123, 34);
            this.btnReturnCar.TabIndex = 11;
            this.btnReturnCar.Text = "ReturnCar";
            this.btnReturnCar.UseVisualStyleBackColor = false;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // lblVehicleInformation
            // 
            this.lblVehicleInformation.AutoSize = true;
            this.lblVehicleInformation.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblVehicleInformation.Location = new System.Drawing.Point(12, 698);
            this.lblVehicleInformation.Name = "lblVehicleInformation";
            this.lblVehicleInformation.Size = new System.Drawing.Size(179, 18);
            this.lblVehicleInformation.TabIndex = 12;
            this.lblVehicleInformation.Text = "Vehicle Information";
            this.lblVehicleInformation.Click += new System.EventHandler(this.lblVehicleInformation_Click);
            // 
            // lbxVehicleInformation
            // 
            this.lbxVehicleInformation.FormattingEnabled = true;
            this.lbxVehicleInformation.ItemHeight = 18;
            this.lbxVehicleInformation.Location = new System.Drawing.Point(12, 719);
            this.lbxVehicleInformation.Name = "lbxVehicleInformation";
            this.lbxVehicleInformation.Size = new System.Drawing.Size(1132, 22);
            this.lbxVehicleInformation.TabIndex = 13;
            this.lbxVehicleInformation.SelectedIndexChanged += new System.EventHandler(this.lbxVehicleInformation_SelectedIndexChanged);
            // 
            // LSVStatus
            // 
            this.LSVStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LSVStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVStatus});
            this.LSVStatus.HideSelection = false;
            this.LSVStatus.Location = new System.Drawing.Point(318, 30);
            this.LSVStatus.Name = "LSVStatus";
            this.LSVStatus.Size = new System.Drawing.Size(826, 118);
            this.LSVStatus.TabIndex = 14;
            this.LSVStatus.UseCompatibleStateImageBehavior = false;
            this.LSVStatus.View = System.Windows.Forms.View.Details;
            this.LSVStatus.SelectedIndexChanged += new System.EventHandler(this.LSVStatus_SelectedIndexChanged);
            // 
            // LVStatus
            // 
            this.LVStatus.Text = "Number";
            // 
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblRentalID.Location = new System.Drawing.Point(21, 130);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(80, 18);
            this.lblRentalID.TabIndex = 15;
            this.lblRentalID.Text = "RentalID";
            this.lblRentalID.Click += new System.EventHandler(this.lblRentalID_Click);
            // 
            // tbxRentalID
            // 
            this.tbxRentalID.Location = new System.Drawing.Point(135, 120);
            this.tbxRentalID.Name = "tbxRentalID";
            this.tbxRentalID.Size = new System.Drawing.Size(175, 28);
            this.tbxRentalID.TabIndex = 16;
            this.tbxRentalID.TextChanged += new System.EventHandler(this.tbxRentalID_TextChanged);
            // 
            // lbxInfo
            // 
            this.lbxInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbxInfo.FormattingEnabled = true;
            this.lbxInfo.ItemHeight = 18;
            this.lbxInfo.Location = new System.Drawing.Point(364, 339);
            this.lbxInfo.Name = "lbxInfo";
            this.lbxInfo.Size = new System.Drawing.Size(780, 238);
            this.lbxInfo.TabIndex = 18;
            this.lbxInfo.SelectedIndexChanged += new System.EventHandler(this.lbxInfo_SelectedIndexChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblInfo.Location = new System.Drawing.Point(361, 318);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(107, 18);
            this.lblInfo.TabIndex = 19;
            this.lblInfo.Text = "Information";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(1006, 654);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 41);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CarRentalSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 753);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lbxInfo);
            this.Controls.Add(this.tbxRentalID);
            this.Controls.Add(this.lblRentalID);
            this.Controls.Add(this.LSVStatus);
            this.Controls.Add(this.lbxVehicleInformation);
            this.Controls.Add(this.lblVehicleInformation);
            this.Controls.Add(this.btnReturnCar);
            this.Controls.Add(this.btnRentCar);
            this.Controls.Add(this.lbxCarList);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.tbxCarID);
            this.Controls.Add(this.tbxCustomerID);
            this.Controls.Add(this.lblPopularmodels);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblCarID);
            this.Controls.Add(this.lblCustomerID);
            this.Name = "CarRentalSystem";
            this.Text = "CarRentalSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblPopularmodels;
        private System.Windows.Forms.TextBox tbxCustomerID;
        private System.Windows.Forms.TextBox tbxCarID;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.ListBox lbxCarList;
        private System.Windows.Forms.Button btnRentCar;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Label lblVehicleInformation;
        private System.Windows.Forms.ListBox lbxVehicleInformation;
        private System.Windows.Forms.ListView LSVStatus;
        private System.Windows.Forms.ColumnHeader LVStatus;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.TextBox tbxRentalID;
        private System.Windows.Forms.ListBox lbxInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnExit;
    }
}


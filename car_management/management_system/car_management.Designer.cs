﻿namespace management_system
{
    partial class car_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(car_management));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carmodel = new System.Windows.Forms.TextBox();
            this.carbrand = new System.Windows.Forms.TextBox();
            this.caryear = new System.Windows.Forms.TextBox();
            this.carprice = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cardetails = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.carstatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.carListbox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.cardetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD CAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 486);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "REMOVE CAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(98, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(98, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(98, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(98, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "price";
            // 
            // carmodel
            // 
            this.carmodel.Location = new System.Drawing.Point(218, 75);
            this.carmodel.Name = "carmodel";
            this.carmodel.Size = new System.Drawing.Size(100, 22);
            this.carmodel.TabIndex = 11;
            // 
            // carbrand
            // 
            this.carbrand.Location = new System.Drawing.Point(218, 136);
            this.carbrand.Name = "carbrand";
            this.carbrand.Size = new System.Drawing.Size(100, 22);
            this.carbrand.TabIndex = 12;
            // 
            // caryear
            // 
            this.caryear.Location = new System.Drawing.Point(218, 194);
            this.caryear.Name = "caryear";
            this.caryear.Size = new System.Drawing.Size(100, 22);
            this.caryear.TabIndex = 13;
            // 
            // carprice
            // 
            this.carprice.Location = new System.Drawing.Point(218, 253);
            this.carprice.Name = "carprice";
            this.carprice.Size = new System.Drawing.Size(100, 22);
            this.carprice.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "UPDATE CAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(251, 486);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 31);
            this.button4.TabIndex = 16;
            this.button4.Text = "VIEW CAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cardetails
            // 
            this.cardetails.BackColor = System.Drawing.Color.White;
            this.cardetails.Controls.Add(this.id);
            this.cardetails.Controls.Add(this.label7);
            this.cardetails.Controls.Add(this.carstatus);
            this.cardetails.Controls.Add(this.label5);
            this.cardetails.Controls.Add(this.button4);
            this.cardetails.Controls.Add(this.button2);
            this.cardetails.Controls.Add(this.carprice);
            this.cardetails.Controls.Add(this.caryear);
            this.cardetails.Controls.Add(this.carbrand);
            this.cardetails.Controls.Add(this.carmodel);
            this.cardetails.Controls.Add(this.label4);
            this.cardetails.Controls.Add(this.label3);
            this.cardetails.Controls.Add(this.label2);
            this.cardetails.Controls.Add(this.label1);
            this.cardetails.Controls.Add(this.button3);
            this.cardetails.Controls.Add(this.button1);
            this.cardetails.Location = new System.Drawing.Point(90, 64);
            this.cardetails.Name = "cardetails";
            this.cardetails.Size = new System.Drawing.Size(458, 539);
            this.cardetails.TabIndex = 17;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(218, 369);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 20;
            this.id.TextChanged += new System.EventHandler(this.carid_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(102, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "CarID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // carstatus
            // 
            this.carstatus.Location = new System.Drawing.Point(218, 312);
            this.carstatus.Name = "carstatus";
            this.carstatus.Size = new System.Drawing.Size(100, 22);
            this.carstatus.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(98, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Status";
            // 
            // carListbox
            // 
            this.carListbox.BackColor = System.Drawing.Color.White;
            this.carListbox.FormattingEnabled = true;
            this.carListbox.ItemHeight = 16;
            this.carListbox.Location = new System.Drawing.Point(724, 71);
            this.carListbox.Name = "carListbox";
            this.carListbox.Size = new System.Drawing.Size(385, 532);
            this.carListbox.TabIndex = 18;
            this.carListbox.SelectedIndexChanged += new System.EventHandler(this.carListbox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(755, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "CarList";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1050, 680);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 32);
            this.button5.TabIndex = 20;
            this.button5.Text = "EXIT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // car_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1211, 753);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.carListbox);
            this.Controls.Add(this.cardetails);
            this.DoubleBuffered = true;
            this.Name = "car_management";
            this.Text = "car management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cardetails.ResumeLayout(false);
            this.cardetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox carmodel;
        private System.Windows.Forms.TextBox carbrand;
        private System.Windows.Forms.TextBox caryear;
        private System.Windows.Forms.TextBox carprice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel cardetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox carListbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox carstatus;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox id;
    }
}


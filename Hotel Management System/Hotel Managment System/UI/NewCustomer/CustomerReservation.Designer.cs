
namespace Hotel_Managment_System.UI
{
    partial class CustomerReservation
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
            this.dpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbHes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbGuest = new System.Windows.Forms.ComboBox();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btReserve = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpBirthDate
            // 
            this.dpBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpBirthDate.Location = new System.Drawing.Point(141, 117);
            this.dpBirthDate.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dpBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dpBirthDate.Name = "dpBirthDate";
            this.dpBirthDate.Size = new System.Drawing.Size(119, 22);
            this.dpBirthDate.TabIndex = 0;
            this.dpBirthDate.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Birth Date:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(141, 59);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(119, 22);
            this.tbName.TabIndex = 4;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(141, 89);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(119, 22);
            this.tbSurname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(141, 29);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(119, 22);
            this.tbID.TabIndex = 7;
            this.tbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbID_KeyPress);
            // 
            // tbHes
            // 
            this.tbHes.Location = new System.Drawing.Point(141, 149);
            this.tbHes.Name = "tbHes";
            this.tbHes.Size = new System.Drawing.Size(119, 22);
            this.tbHes.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "HES Code:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbHes);
            this.groupBox1.Controls.Add(this.dpBirthDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbSurname);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(136, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 192);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbGuest);
            this.groupBox2.Controls.Add(this.dpEndDate);
            this.groupBox2.Controls.Add(this.dpStartDate);
            this.groupBox2.Controls.Add(this.cbRoomType);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(469, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 192);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Information";
            // 
            // cbGuest
            // 
            this.cbGuest.FormattingEnabled = true;
            this.cbGuest.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbGuest.Location = new System.Drawing.Point(118, 122);
            this.cbGuest.Name = "cbGuest";
            this.cbGuest.Size = new System.Drawing.Size(133, 24);
            this.cbGuest.TabIndex = 16;
            this.cbGuest.Text = "Guest Number";
            // 
            // dpEndDate
            // 
            this.dpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpEndDate.Location = new System.Drawing.Point(118, 92);
            this.dpEndDate.MinDate = this.dpStartDate.Value;
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(131, 22);
            this.dpEndDate.TabIndex = 15;
            this.dpEndDate.Value = this.dpStartDate.Value;
            // 
            // dpStartDate
            // 
            this.dpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpStartDate.Location = new System.Drawing.Point(118, 62);
            this.dpStartDate.MinDate = new System.DateTime(2021, 12, 30, 0, 0, 0, 0);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(131, 22);
            this.dpStartDate.TabIndex = 14;
            this.dpStartDate.ValueChanged += new System.EventHandler(this.dpStartDate_ValueChanged);
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "Double",
            "Quad",
            "Queen",
            "King"});
            this.cbRoomType.Location = new System.Drawing.Point(118, 32);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(131, 24);
            this.cbRoomType.TabIndex = 13;
            this.cbRoomType.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Guests:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "End Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Start Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Room Type:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(147)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(795, 56);
            this.label6.TabIndex = 12;
            this.label6.Text = "Reservation";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btReserve
            // 
            this.btReserve.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btReserve.FlatAppearance.BorderSize = 0;
            this.btReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReserve.ForeColor = System.Drawing.Color.White;
            this.btReserve.Location = new System.Drawing.Point(314, 373);
            this.btReserve.Name = "btReserve";
            this.btReserve.Size = new System.Drawing.Size(225, 51);
            this.btReserve.TabIndex = 17;
            this.btReserve.Text = "Reserve";
            this.btReserve.UseVisualStyleBackColor = false;
            this.btReserve.Click += new System.EventHandler(this.btReserve_Click);
            // 
            // CustomerReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 431);
            this.Controls.Add(this.btReserve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerReservation";
            this.Text = "CustomerReservation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dpBirthDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbHes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGuest;
        private System.Windows.Forms.DateTimePicker dpEndDate;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private System.Windows.Forms.Button btReserve;
    }
}
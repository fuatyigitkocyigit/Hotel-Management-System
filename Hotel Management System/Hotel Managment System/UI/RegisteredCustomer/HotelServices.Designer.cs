
namespace Hotel_Managment_System.UI
{
    partial class HotelServices
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
            this.lbActiveServices = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRequestRoomService = new System.Windows.Forms.Button();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.pnlRequestRoomServiceSubMenu = new System.Windows.Forms.Panel();
            this.btnRoomService = new System.Windows.Forms.Button();
            this.btnRoomCleaning = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMakeReservation = new System.Windows.Forms.Panel();
            this.btnSpa = new System.Windows.Forms.Button();
            this.btnRestraunt = new System.Windows.Forms.Button();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.pnlRequestRoomServiceSubMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMakeReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbActiveServices
            // 
            this.lbActiveServices.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbActiveServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbActiveServices.ForeColor = System.Drawing.Color.White;
            this.lbActiveServices.FormattingEnabled = true;
            this.lbActiveServices.ItemHeight = 20;
            this.lbActiveServices.Items.AddRange(new object[] {
            "Room Service",
            "Restaurant",
            "Spa",
            "Car Washing"});
            this.lbActiveServices.Location = new System.Drawing.Point(6, 24);
            this.lbActiveServices.Name = "lbActiveServices";
            this.lbActiveServices.Size = new System.Drawing.Size(166, 100);
            this.lbActiveServices.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbActiveServices);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aviable Services";
            // 
            // btnRequestRoomService
            // 
            this.btnRequestRoomService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequestRoomService.FlatAppearance.BorderSize = 0;
            this.btnRequestRoomService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestRoomService.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestRoomService.ForeColor = System.Drawing.Color.White;
            this.btnRequestRoomService.Location = new System.Drawing.Point(0, 131);
            this.btnRequestRoomService.Name = "btnRequestRoomService";
            this.btnRequestRoomService.Size = new System.Drawing.Size(200, 44);
            this.btnRequestRoomService.TabIndex = 2;
            this.btnRequestRoomService.Text = "Request Room Service";
            this.btnRequestRoomService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequestRoomService.UseVisualStyleBackColor = true;
            this.btnRequestRoomService.Click += new System.EventHandler(this.btnRequestRoomService_Click);
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMakeReservation.FlatAppearance.BorderSize = 0;
            this.btnMakeReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReservation.ForeColor = System.Drawing.Color.White;
            this.btnMakeReservation.Location = new System.Drawing.Point(0, 265);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(200, 42);
            this.btnMakeReservation.TabIndex = 3;
            this.btnMakeReservation.Text = "Make Reservation";
            this.btnMakeReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakeReservation.UseVisualStyleBackColor = true;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // pnlRequestRoomServiceSubMenu
            // 
            this.pnlRequestRoomServiceSubMenu.Controls.Add(this.btnRoomService);
            this.pnlRequestRoomServiceSubMenu.Controls.Add(this.btnRoomCleaning);
            this.pnlRequestRoomServiceSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRequestRoomServiceSubMenu.Location = new System.Drawing.Point(0, 175);
            this.pnlRequestRoomServiceSubMenu.Name = "pnlRequestRoomServiceSubMenu";
            this.pnlRequestRoomServiceSubMenu.Size = new System.Drawing.Size(200, 90);
            this.pnlRequestRoomServiceSubMenu.TabIndex = 4;
            // 
            // btnRoomService
            // 
            this.btnRoomService.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRoomService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomService.FlatAppearance.BorderSize = 0;
            this.btnRoomService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomService.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomService.ForeColor = System.Drawing.Color.White;
            this.btnRoomService.Location = new System.Drawing.Point(0, 44);
            this.btnRoomService.Name = "btnRoomService";
            this.btnRoomService.Size = new System.Drawing.Size(200, 44);
            this.btnRoomService.TabIndex = 5;
            this.btnRoomService.Text = "Room Service";
            this.btnRoomService.UseVisualStyleBackColor = false;
            this.btnRoomService.Click += new System.EventHandler(this.btnRoomService_Click);
            // 
            // btnRoomCleaning
            // 
            this.btnRoomCleaning.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRoomCleaning.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomCleaning.FlatAppearance.BorderSize = 0;
            this.btnRoomCleaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomCleaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomCleaning.ForeColor = System.Drawing.Color.White;
            this.btnRoomCleaning.Location = new System.Drawing.Point(0, 0);
            this.btnRoomCleaning.Name = "btnRoomCleaning";
            this.btnRoomCleaning.Size = new System.Drawing.Size(200, 44);
            this.btnRoomCleaning.TabIndex = 6;
            this.btnRoomCleaning.Text = "Room Cleaning";
            this.btnRoomCleaning.UseVisualStyleBackColor = false;
            this.btnRoomCleaning.Click += new System.EventHandler(this.btnRoomCleaning_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pnlMakeReservation);
            this.panel1.Controls.Add(this.btnMakeReservation);
            this.panel1.Controls.Add(this.pnlRequestRoomServiceSubMenu);
            this.panel1.Controls.Add(this.btnRequestRoomService);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 411);
            this.panel1.TabIndex = 5;
            // 
            // pnlMakeReservation
            // 
            this.pnlMakeReservation.Controls.Add(this.btnSpa);
            this.pnlMakeReservation.Controls.Add(this.btnRestraunt);
            this.pnlMakeReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMakeReservation.Location = new System.Drawing.Point(0, 307);
            this.pnlMakeReservation.Name = "pnlMakeReservation";
            this.pnlMakeReservation.Size = new System.Drawing.Size(200, 89);
            this.pnlMakeReservation.TabIndex = 7;
            // 
            // btnSpa
            // 
            this.btnSpa.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSpa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpa.FlatAppearance.BorderSize = 0;
            this.btnSpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpa.ForeColor = System.Drawing.Color.White;
            this.btnSpa.Location = new System.Drawing.Point(0, 44);
            this.btnSpa.Name = "btnSpa";
            this.btnSpa.Size = new System.Drawing.Size(200, 44);
            this.btnSpa.TabIndex = 5;
            this.btnSpa.Text = "Spa";
            this.btnSpa.UseVisualStyleBackColor = false;
            this.btnSpa.Click += new System.EventHandler(this.btnSpa_Click);
            // 
            // btnRestraunt
            // 
            this.btnRestraunt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRestraunt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRestraunt.FlatAppearance.BorderSize = 0;
            this.btnRestraunt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestraunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestraunt.ForeColor = System.Drawing.Color.White;
            this.btnRestraunt.Location = new System.Drawing.Point(0, 0);
            this.btnRestraunt.Name = "btnRestraunt";
            this.btnRestraunt.Size = new System.Drawing.Size(200, 44);
            this.btnRestraunt.TabIndex = 6;
            this.btnRestraunt.Text = "Restaurant";
            this.btnRestraunt.UseVisualStyleBackColor = false;
            this.btnRestraunt.Click += new System.EventHandler(this.btnRestraunt_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(200, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(653, 411);
            this.pnlChildForm.TabIndex = 6;
            // 
            // HotelServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 411);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "HotelServices";
            this.Text = "Hotel Services";
            this.groupBox1.ResumeLayout(false);
            this.pnlRequestRoomServiceSubMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlMakeReservation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbActiveServices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRequestRoomService;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Panel pnlRequestRoomServiceSubMenu;
        private System.Windows.Forms.Button btnRoomCleaning;
        private System.Windows.Forms.Button btnRoomService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMakeReservation;
        private System.Windows.Forms.Button btnSpa;
        private System.Windows.Forms.Button btnRestraunt;
        private System.Windows.Forms.Panel pnlChildForm;
    }
}
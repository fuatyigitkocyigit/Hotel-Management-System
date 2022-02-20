
namespace Hotel_Managment_System.UI
{
    partial class ChechInOut
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
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewCheckInOut = new System.Windows.Forms.Button();
            this.btnSeePersonalInformations = new System.Windows.Forms.Button();
            this.btnCheckAviableRooms = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(200, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(600, 450);
            this.pnlChildForm.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnViewCheckInOut);
            this.panel1.Controls.Add(this.btnSeePersonalInformations);
            this.panel1.Controls.Add(this.btnCheckAviableRooms);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 9;
            // 
            // btnViewCheckInOut
            // 
            this.btnViewCheckInOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewCheckInOut.FlatAppearance.BorderSize = 0;
            this.btnViewCheckInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCheckInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCheckInOut.ForeColor = System.Drawing.Color.White;
            this.btnViewCheckInOut.Location = new System.Drawing.Point(0, 86);
            this.btnViewCheckInOut.Name = "btnViewCheckInOut";
            this.btnViewCheckInOut.Size = new System.Drawing.Size(200, 42);
            this.btnViewCheckInOut.TabIndex = 4;
            this.btnViewCheckInOut.Text = "View Check In/Out";
            this.btnViewCheckInOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCheckInOut.UseVisualStyleBackColor = true;
            this.btnViewCheckInOut.Visible = false;
            this.btnViewCheckInOut.Click += new System.EventHandler(this.btnViewCheckInOut_Click);
            // 
            // btnSeePersonalInformations
            // 
            this.btnSeePersonalInformations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeePersonalInformations.FlatAppearance.BorderSize = 0;
            this.btnSeePersonalInformations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeePersonalInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeePersonalInformations.ForeColor = System.Drawing.Color.White;
            this.btnSeePersonalInformations.Location = new System.Drawing.Point(0, 44);
            this.btnSeePersonalInformations.Name = "btnSeePersonalInformations";
            this.btnSeePersonalInformations.Size = new System.Drawing.Size(200, 42);
            this.btnSeePersonalInformations.TabIndex = 3;
            this.btnSeePersonalInformations.Text = "See Personal Informations";
            this.btnSeePersonalInformations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeePersonalInformations.UseVisualStyleBackColor = true;
            this.btnSeePersonalInformations.Visible = false;
            this.btnSeePersonalInformations.Click += new System.EventHandler(this.btnSeePersonalInformations_Click);
            // 
            // btnCheckAviableRooms
            // 
            this.btnCheckAviableRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckAviableRooms.FlatAppearance.BorderSize = 0;
            this.btnCheckAviableRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAviableRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAviableRooms.ForeColor = System.Drawing.Color.White;
            this.btnCheckAviableRooms.Location = new System.Drawing.Point(0, 0);
            this.btnCheckAviableRooms.Name = "btnCheckAviableRooms";
            this.btnCheckAviableRooms.Size = new System.Drawing.Size(200, 44);
            this.btnCheckAviableRooms.TabIndex = 2;
            this.btnCheckAviableRooms.Text = "Check Aviable Rooms";
            this.btnCheckAviableRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckAviableRooms.UseVisualStyleBackColor = true;
            this.btnCheckAviableRooms.Visible = false;
            this.btnCheckAviableRooms.Click += new System.EventHandler(this.btnCheckAviableRooms_Click);
            // 
            // ChechInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "ChechInOut";
            this.Text = "Chech In/Out";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSeePersonalInformations;
        private System.Windows.Forms.Button btnCheckAviableRooms;
        private System.Windows.Forms.Button btnViewCheckInOut;
    }
}
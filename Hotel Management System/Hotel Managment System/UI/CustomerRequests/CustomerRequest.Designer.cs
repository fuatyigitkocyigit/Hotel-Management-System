
namespace Hotel_Managment_System.UI
{
    partial class CustomerRequest
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
            this.btnRoomCleaningRequests = new System.Windows.Forms.Button();
            this.btnRoomServiceRequests = new System.Windows.Forms.Button();
            this.btnRestaurantRequest = new System.Windows.Forms.Button();
            this.btnSpaRequest = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btnRoomCleaningRequests);
            this.panel1.Controls.Add(this.btnRoomServiceRequests);
            this.panel1.Controls.Add(this.btnRestaurantRequest);
            this.panel1.Controls.Add(this.btnSpaRequest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 9;
            // 
            // btnRoomCleaningRequests
            // 
            this.btnRoomCleaningRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomCleaningRequests.FlatAppearance.BorderSize = 0;
            this.btnRoomCleaningRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomCleaningRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomCleaningRequests.ForeColor = System.Drawing.Color.White;
            this.btnRoomCleaningRequests.Location = new System.Drawing.Point(0, 128);
            this.btnRoomCleaningRequests.Name = "btnRoomCleaningRequests";
            this.btnRoomCleaningRequests.Size = new System.Drawing.Size(200, 42);
            this.btnRoomCleaningRequests.TabIndex = 5;
            this.btnRoomCleaningRequests.Text = "Room Cleaning Requests";
            this.btnRoomCleaningRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomCleaningRequests.UseVisualStyleBackColor = true;
            this.btnRoomCleaningRequests.Visible = false;
            this.btnRoomCleaningRequests.Click += new System.EventHandler(this.btnRoomCleaningRequests_Click);
            // 
            // btnRoomServiceRequests
            // 
            this.btnRoomServiceRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomServiceRequests.FlatAppearance.BorderSize = 0;
            this.btnRoomServiceRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomServiceRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomServiceRequests.ForeColor = System.Drawing.Color.White;
            this.btnRoomServiceRequests.Location = new System.Drawing.Point(0, 86);
            this.btnRoomServiceRequests.Name = "btnRoomServiceRequests";
            this.btnRoomServiceRequests.Size = new System.Drawing.Size(200, 42);
            this.btnRoomServiceRequests.TabIndex = 4;
            this.btnRoomServiceRequests.Text = "Room Service Requests";
            this.btnRoomServiceRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomServiceRequests.UseVisualStyleBackColor = true;
            this.btnRoomServiceRequests.Visible = false;
            this.btnRoomServiceRequests.Click += new System.EventHandler(this.btnRoomServiceRequests_Click);
            // 
            // btnRestaurantRequest
            // 
            this.btnRestaurantRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRestaurantRequest.FlatAppearance.BorderSize = 0;
            this.btnRestaurantRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurantRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurantRequest.ForeColor = System.Drawing.Color.White;
            this.btnRestaurantRequest.Location = new System.Drawing.Point(0, 44);
            this.btnRestaurantRequest.Name = "btnRestaurantRequest";
            this.btnRestaurantRequest.Size = new System.Drawing.Size(200, 42);
            this.btnRestaurantRequest.TabIndex = 3;
            this.btnRestaurantRequest.Text = "Restaurant Requests";
            this.btnRestaurantRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurantRequest.UseVisualStyleBackColor = true;
            this.btnRestaurantRequest.Visible = false;
            this.btnRestaurantRequest.Click += new System.EventHandler(this.btnRestaurantRequest_Click);
            // 
            // btnSpaRequest
            // 
            this.btnSpaRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpaRequest.FlatAppearance.BorderSize = 0;
            this.btnSpaRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpaRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaRequest.ForeColor = System.Drawing.Color.White;
            this.btnSpaRequest.Location = new System.Drawing.Point(0, 0);
            this.btnSpaRequest.Name = "btnSpaRequest";
            this.btnSpaRequest.Size = new System.Drawing.Size(200, 44);
            this.btnSpaRequest.TabIndex = 2;
            this.btnSpaRequest.Text = "Spa Requests";
            this.btnSpaRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpaRequest.UseVisualStyleBackColor = true;
            this.btnSpaRequest.Visible = false;
            this.btnSpaRequest.Click += new System.EventHandler(this.btnSpaRequest_Click);
            // 
            // CustomerRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerRequest";
            this.Text = "Customer Request";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRestaurantRequest;
        private System.Windows.Forms.Button btnSpaRequest;
        private System.Windows.Forms.Button btnRoomCleaningRequests;
        private System.Windows.Forms.Button btnRoomServiceRequests;
    }
}

namespace Hotel_Managment_System.UI
{
    partial class Payment
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
            this.btnViewCurrentPayment = new System.Windows.Forms.Button();
            this.btnPaymentManagament = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(200, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(600, 450);
            this.pnlChildForm.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnViewCurrentPayment);
            this.panel1.Controls.Add(this.btnPaymentManagament);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 7;
            // 
            // btnViewCurrentPayment
            // 
            this.btnViewCurrentPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewCurrentPayment.FlatAppearance.BorderSize = 0;
            this.btnViewCurrentPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCurrentPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCurrentPayment.ForeColor = System.Drawing.Color.White;
            this.btnViewCurrentPayment.Location = new System.Drawing.Point(0, 44);
            this.btnViewCurrentPayment.Name = "btnViewCurrentPayment";
            this.btnViewCurrentPayment.Size = new System.Drawing.Size(200, 42);
            this.btnViewCurrentPayment.TabIndex = 3;
            this.btnViewCurrentPayment.Text = "View Current Payment";
            this.btnViewCurrentPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCurrentPayment.UseVisualStyleBackColor = true;
            this.btnViewCurrentPayment.Click += new System.EventHandler(this.btnViewCurrentPayment_Click);
            // 
            // btnPaymentManagament
            // 
            this.btnPaymentManagament.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaymentManagament.FlatAppearance.BorderSize = 0;
            this.btnPaymentManagament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentManagament.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentManagament.ForeColor = System.Drawing.Color.White;
            this.btnPaymentManagament.Location = new System.Drawing.Point(0, 0);
            this.btnPaymentManagament.Name = "btnPaymentManagament";
            this.btnPaymentManagament.Size = new System.Drawing.Size(200, 44);
            this.btnPaymentManagament.TabIndex = 2;
            this.btnPaymentManagament.Text = "Payment Management";
            this.btnPaymentManagament.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentManagament.UseVisualStyleBackColor = true;
            this.btnPaymentManagament.Visible = false;
            this.btnPaymentManagament.Click += new System.EventHandler(this.btnPaymentManagament_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewCurrentPayment;
        private System.Windows.Forms.Button btnPaymentManagament;
    }
}
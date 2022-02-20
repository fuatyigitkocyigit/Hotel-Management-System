
namespace Hotel_Managment_System.UI
{
    partial class Shift
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
            this.btnViewCurrentShift = new System.Windows.Forms.Button();
            this.btnShiftManagament = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btnViewCurrentShift);
            this.panel1.Controls.Add(this.btnShiftManagament);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 9;
            // 
            // btnViewCurrentShift
            // 
            this.btnViewCurrentShift.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewCurrentShift.FlatAppearance.BorderSize = 0;
            this.btnViewCurrentShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCurrentShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCurrentShift.ForeColor = System.Drawing.Color.White;
            this.btnViewCurrentShift.Location = new System.Drawing.Point(0, 44);
            this.btnViewCurrentShift.Name = "btnViewCurrentShift";
            this.btnViewCurrentShift.Size = new System.Drawing.Size(200, 42);
            this.btnViewCurrentShift.TabIndex = 3;
            this.btnViewCurrentShift.Text = "View Current Shift";
            this.btnViewCurrentShift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCurrentShift.UseVisualStyleBackColor = true;
            this.btnViewCurrentShift.Click += new System.EventHandler(this.btnViewCurrentShift_Click);
            // 
            // btnShiftManagament
            // 
            this.btnShiftManagament.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShiftManagament.FlatAppearance.BorderSize = 0;
            this.btnShiftManagament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftManagament.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftManagament.ForeColor = System.Drawing.Color.White;
            this.btnShiftManagament.Location = new System.Drawing.Point(0, 0);
            this.btnShiftManagament.Name = "btnShiftManagament";
            this.btnShiftManagament.Size = new System.Drawing.Size(200, 44);
            this.btnShiftManagament.TabIndex = 2;
            this.btnShiftManagament.Text = "Shift Management";
            this.btnShiftManagament.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShiftManagament.UseVisualStyleBackColor = true;
            this.btnShiftManagament.Visible = false;
            this.btnShiftManagament.Click += new System.EventHandler(this.btnShiftManagament_Click);
            // 
            // Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "Shift";
            this.Text = "Shift";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewCurrentShift;
        private System.Windows.Forms.Button btnShiftManagament;
    }
}
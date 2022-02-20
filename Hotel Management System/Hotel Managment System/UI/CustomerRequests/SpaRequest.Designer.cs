
namespace Hotel_Managment_System.UI
{
    partial class SpaRequest
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
            this.lbName = new System.Windows.Forms.Label();
            this.dgCustomerList = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(147)))));
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(635, 56);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "Spa Request";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgCustomerList
            // 
            this.dgCustomerList.AllowUserToAddRows = false;
            this.dgCustomerList.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.CustomerSurname,
            this.Time});
            this.dgCustomerList.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dgCustomerList.Location = new System.Drawing.Point(80, 100);
            this.dgCustomerList.Name = "dgCustomerList";
            this.dgCustomerList.ReadOnly = true;
            this.dgCustomerList.RowHeadersWidth = 51;
            this.dgCustomerList.RowTemplate.Height = 24;
            this.dgCustomerList.Size = new System.Drawing.Size(481, 192);
            this.dgCustomerList.TabIndex = 15;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 125;
            // 
            // CustomerSurname
            // 
            this.CustomerSurname.HeaderText = "Customer Surname";
            this.CustomerSurname.MinimumWidth = 6;
            this.CustomerSurname.Name = "CustomerSurname";
            this.CustomerSurname.ReadOnly = true;
            this.CustomerSurname.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
            // 
            // SpaRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 364);
            this.Controls.Add(this.dgCustomerList);
            this.Controls.Add(this.lbName);
            this.Name = "SpaRequest";
            this.Text = "Spa Request";
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView dgCustomerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}
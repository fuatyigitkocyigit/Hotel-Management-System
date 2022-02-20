
namespace Hotel_Managment_System.UI
{
    partial class PaymentManagement
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
            this.dgWorkerList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkerList)).BeginInit();
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
            this.lbName.TabIndex = 13;
            this.lbName.Text = "Payment Management";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgWorkerList
            // 
            this.dgWorkerList.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgWorkerList.ColumnHeadersHeight = 29;
            this.dgWorkerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.SurnameColumn,
            this.PaymentColumn});
            this.dgWorkerList.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dgWorkerList.Location = new System.Drawing.Point(96, 107);
            this.dgWorkerList.MultiSelect = false;
            this.dgWorkerList.Name = "dgWorkerList";
            this.dgWorkerList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgWorkerList.RowHeadersWidth = 51;
            this.dgWorkerList.RowTemplate.Height = 24;
            this.dgWorkerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWorkerList.Size = new System.Drawing.Size(458, 190);
            this.dgWorkerList.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(110, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "*Select worker and property to change or delete";
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Surname";
            this.SurnameColumn.MinimumWidth = 6;
            this.SurnameColumn.Name = "SurnameColumn";
            // 
            // PaymentColumn
            // 
            this.PaymentColumn.HeaderText = "Payment";
            this.PaymentColumn.MinimumWidth = 6;
            this.PaymentColumn.Name = "PaymentColumn";
            // 
            // PaymentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgWorkerList);
            this.Controls.Add(this.lbName);
            this.Name = "PaymentManagement";
            this.Text = "PaymentManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView dgWorkerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentColumn;
    }
}
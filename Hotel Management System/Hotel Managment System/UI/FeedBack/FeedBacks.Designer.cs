
namespace Hotel_Managment_System.UI
{
    partial class FeedBacks
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
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeedBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lbName.Size = new System.Drawing.Size(853, 56);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "FeedBacks";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgWorkerList
            // 
            this.dgWorkerList.AllowUserToAddRows = false;
            this.dgWorkerList.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgWorkerList.ColumnHeadersHeight = 29;
            this.dgWorkerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.SurnameColumn,
            this.FeedBack});
            this.dgWorkerList.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dgWorkerList.Location = new System.Drawing.Point(45, 85);
            this.dgWorkerList.MultiSelect = false;
            this.dgWorkerList.Name = "dgWorkerList";
            this.dgWorkerList.ReadOnly = true;
            this.dgWorkerList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgWorkerList.RowHeadersWidth = 51;
            this.dgWorkerList.RowTemplate.Height = 24;
            this.dgWorkerList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgWorkerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWorkerList.Size = new System.Drawing.Size(767, 284);
            this.dgWorkerList.TabIndex = 15;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 135;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Surname";
            this.SurnameColumn.MinimumWidth = 6;
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.ReadOnly = true;
            this.SurnameColumn.Width = 135;
            // 
            // FeedBack
            // 
            this.FeedBack.HeaderText = "FeedBack";
            this.FeedBack.MinimumWidth = 6;
            this.FeedBack.Name = "FeedBack";
            this.FeedBack.ReadOnly = true;
            this.FeedBack.Width = 160;
            // 
            // FeedBacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 411);
            this.Controls.Add(this.dgWorkerList);
            this.Controls.Add(this.lbName);
            this.Name = "FeedBacks";
            this.Text = "FeedBacks";
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView dgWorkerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeedBack;
    }
}
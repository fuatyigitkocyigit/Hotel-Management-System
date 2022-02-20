
namespace Hotel_Managment_System.UI
{
    partial class RoomCleaningRequest
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
            this.dgRoomList = new System.Windows.Forms.DataGridView();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRoomList
            // 
            this.dgRoomList.AllowUserToAddRows = false;
            this.dgRoomList.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.Time});
            this.dgRoomList.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dgRoomList.Location = new System.Drawing.Point(80, 100);
            this.dgRoomList.Name = "dgRoomList";
            this.dgRoomList.ReadOnly = true;
            this.dgRoomList.RowHeadersWidth = 51;
            this.dgRoomList.RowTemplate.Height = 24;
            this.dgRoomList.Size = new System.Drawing.Size(481, 192);
            this.dgRoomList.TabIndex = 19;
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "Room Number";
            this.RoomNumber.MinimumWidth = 6;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            this.RoomNumber.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
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
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Room Service Request";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RoomCleaningRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 364);
            this.Controls.Add(this.dgRoomList);
            this.Controls.Add(this.lbName);
            this.Name = "RoomCleaningRequest";
            this.Text = "RoomCleaningRequest";
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRoomList;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Label lbName;
    }
}
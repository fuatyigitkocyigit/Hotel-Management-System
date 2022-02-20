
namespace Hotel_Managment_System.UI
{
    partial class ViewCheckInOut
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
            this.lbRequested = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCurrent = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbName = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRequested
            // 
            this.lbRequested.FormattingEnabled = true;
            this.lbRequested.ItemHeight = 16;
            this.lbRequested.Items.AddRange(new object[] {
            "Uzma Lawrence\t\tRoom 354",
            "Maximillian Hogan\t\tRoom 354",
            "Rimsha Price\t\tRoom 354",
            "Fraya Li\t\t\tRoom 244",
            "Arlo Willis\t\t\tRoom 244",
            "Mazie Connolly\t\tRoom 123",
            "Kuba Perkins\t\tRoom 123",
            "Anis Levy\t\tRoom 653",
            "Blossom Houston\t\tRoom 256",
            "John-James Coombes\tRoom 345"});
            this.lbRequested.Location = new System.Drawing.Point(12, 21);
            this.lbRequested.Name = "lbRequested";
            this.lbRequested.Size = new System.Drawing.Size(273, 308);
            this.lbRequested.TabIndex = 0;
            this.lbRequested.SelectedIndexChanged += new System.EventHandler(this.lbCurrent_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCurrent);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(297, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 347);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check Out";
            // 
            // lbCurrent
            // 
            this.lbCurrent.FormattingEnabled = true;
            this.lbCurrent.ItemHeight = 16;
            this.lbCurrent.Items.AddRange(new object[] {
            "Ana Haney\t\tRoom 453",
            "Tomos Keenan\t\tRoom 643",
            "Clare Salazar\t\tRoom 864",
            "Rahma Best\t\tRoom 244",
            "Riaan Stevenson\t\tRoom 135",
            "Salim Cleveland\t\tRoom 732",
            "Shelley Snider\t\tRoom 367",
            "Jane Weir\t\tRoom 453",
            "Aleyna Delgado\t\tRoom 356",
            "Orion Dyer\t\tRoom 168"});
            this.lbCurrent.Location = new System.Drawing.Point(6, 21);
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(277, 308);
            this.lbCurrent.TabIndex = 1;
            this.lbCurrent.SelectedIndexChanged += new System.EventHandler(this.lbCurrent_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRequested);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 347);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check In";
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(147)))));
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(582, 56);
            this.lbName.TabIndex = 17;
            this.lbName.Text = "Check In/Out";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewCheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbName);
            this.Name = "ViewCheckInOut";
            this.Text = "ViewCheckInOut";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRequested;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbCurrent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbName;
    }
}
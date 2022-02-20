using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment_System.UI
{
    public partial class ShiftManagament : Form
    {
        public ShiftManagament()
        {
            InitializeComponent();
        }

        private void addTime(object sender, EventArgs e)
        {
            

            String[] aviable = { "Full", "Empty" };
            FlowLayoutPanel[] flow= { flowLayoutPanel1, flowLayoutPanel2, flowLayoutPanel3, flowLayoutPanel4 };
            foreach (FlowLayoutPanel item in flow)
            {
                item.Controls.Clear();

                for (double i = 9.00; i <= 18.00; i++)
                {
                    Button temp = new Button();
                    Random num = new Random();

                    temp.FlatStyle = FlatStyle.Flat;
                    temp.FlatAppearance.BorderSize = 0;
                    temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    string a = aviable[num.Next(2)];
                    string number = String.Format("{0:00.00}", i);
                    temp.Text = number;
                    temp.AutoSize = true;

                    if (a.Equals("Full"))
                        temp.BackColor = Color.Red;
                    else
                        temp.BackColor = Color.Green;

                    temp.Click += new EventHandler(this.place_Click);
                    item.Controls.Add(temp);
                }
            }
            pnlWorkers.Visible = true;
        }

        private void place_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            if (temp.BackColor == Color.Green)
            {
                string message = "Are you sure to change working hour "+temp.Text;
                string title = "Working Hour Confim";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    temp.BackColor = Color.Red;

                }
                
            }
            else
            {
                string message = "Are you sure to change working hour " + temp.Text;
                string title = "Working Hour Confim";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    temp.BackColor = Color.Green;

                }
            }

        }

        
    }
}

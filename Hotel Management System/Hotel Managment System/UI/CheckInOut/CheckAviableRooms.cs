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
    public partial class CheckAviableRooms : Form
    {
        public CheckAviableRooms()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            String[] aviable = { "Reserved", "Empty" };

            for (double i = 100; i < 200; i = i+10)
            {
                Button temp = new Button();
                Random num = new Random();

                temp.FlatStyle = FlatStyle.Flat;
                temp.FlatAppearance.BorderSize = 0;
                temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                string a = aviable[num.Next(2)];
                string number = String.Format("{0}", i);
                temp.Text = "Room " + number;
                temp.AutoSize = true;
                if (a.Equals("Reserved"))
                    temp.BackColor = Color.Red;
                else
                    temp.BackColor = Color.Green;

                temp.Click += new EventHandler(this.place_Click);
                flowLayoutPanel1.Controls.Add(temp);
            }
        }

        private void place_Click(object sender, EventArgs e)
        {

            Button temp = sender as Button;
            if (temp.BackColor == Color.Green)
            {
                string message = "Room number"+ temp.Text +"will be selected.\nDo you confirm?";
                string title = "Room Confirm";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    temp.BackColor = Color.Red;

                }
            }

        }
    }
}

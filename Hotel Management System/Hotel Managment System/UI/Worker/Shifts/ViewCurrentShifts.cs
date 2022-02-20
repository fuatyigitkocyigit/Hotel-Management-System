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
    public partial class ViewCurrentShifts : Form
    {
        public ViewCurrentShifts()
        {
            InitializeComponent();
        }

        private void addTime(object sender, EventArgs e)
        {


            String[] aviable = { "Full", "Empty" };


            flowLayoutPanel1.Controls.Clear();

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

                flowLayoutPanel1.Controls.Add(temp);
            }
        
            
        }
    }
}

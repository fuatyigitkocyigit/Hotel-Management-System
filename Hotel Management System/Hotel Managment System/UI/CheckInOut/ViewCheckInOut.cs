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
    public partial class ViewCheckInOut : Form
    {
        public ViewCheckInOut()
        {
            InitializeComponent();
        }

        private void lbCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox temp = sender as ListBox;
            temp.SelectedItem.ToString();

            MessageBox.Show("Customer Name, Surname and Room Number\n" +temp.SelectedItem.ToString().Trim());
        }
    }
}

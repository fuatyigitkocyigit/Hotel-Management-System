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
    public partial class SeePersonalInformation : Form
    {
        public SeePersonalInformation()
        {
            InitializeComponent();
        }

        private void lbRequested_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox temp = sender as ListBox;
            MessageBox.Show("Customer Name and Surname: "+temp.SelectedItem.ToString()+"\nAge: 25\nGneder: Male");
        }
    }
}

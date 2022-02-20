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
    public partial class CustomerReservation : Form
    {
        public CustomerReservation()
        {
            InitializeComponent();
        }

        private void btReserve_Click(object sender, EventArgs e)
        {
            if (tbID.Text != string.Empty && tbName.Text != string.Empty && tbSurname.Text != string.Empty &&
                tbHes.Text != string.Empty && cbRoomType.SelectedItem != default && cbGuest.SelectedItem != default)
            {
                string message = "Are you confiming this room reeservation";
                string title = "Room Confim";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    MessageBox.Show("Your Request Has Been Send to Receptionists");
                }
            }
            else
            {
                MessageBox.Show("Please enter your information.");
            }
            
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dpStartDate_ValueChanged(object sender, EventArgs e)
        {
            this.dpEndDate.Value = this.dpStartDate.Value;
        }
    }
}

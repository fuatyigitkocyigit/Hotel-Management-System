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
    public partial class CustomerFeedBack : Form
    {
        public CustomerFeedBack()
        {
            InitializeComponent();
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            string message = "Are you confiming your Feedback";
            string title = "Feedback Confirm";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Your Feedback Has Been Send to Receptionists");
                
                tbName.Text = string.Empty;
                tbSurname.Text = string.Empty;
                tbID.Text = string.Empty;
                tbHes.Text = string.Empty;
                tbFeedback.Text = string.Empty;
            }
        }
    }
}

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
    public partial class Payment : Form
    {
        string user;
        public Payment(String user)
        {
            InitializeComponent();
            this.user = user;
            if(user.Contains("Manager"))
            {
                btnPaymentManagament.Visible = true;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            if (activeForm == childForm)
                return;

            activeForm = childForm;
            childForm.TopLevel = false;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            this.pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
        private void btnPaymentManagament_Click(object sender, EventArgs e)
        {
            Form temp = new PaymentManagement();
            openChildForm(temp);
        }

        private void btnViewCurrentPayment_Click(object sender, EventArgs e)
        {
            Form temp = new ViewCurrentPayments();
            openChildForm(temp);
        }
    }
}

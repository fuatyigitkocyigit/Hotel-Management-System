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
    public partial class Shift : Form
    {
        string user;
       public Shift(String user)
        {
            InitializeComponent();
            this.user = user;
            if (user.Contains("Manager") || user.Contains("Chef"))
            {
                btnShiftManagament.Visible = true;
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

        private void btnShiftManagament_Click(object sender, EventArgs e)
        {
            Form temp = new ShiftManagament();
            openChildForm(temp);
        }

        private void btnViewCurrentShift_Click(object sender, EventArgs e)
        {
            Form temp = new ViewCurrentShifts();
            openChildForm(temp);
        }
    }
}

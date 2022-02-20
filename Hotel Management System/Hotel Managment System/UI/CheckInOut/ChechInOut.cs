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
    public partial class ChechInOut : Form
    {
        string user;
        bool startPage =false;
        public ChechInOut(String user)
        {
            
            this.user = user;
            if (user.Contains("Manager") || user.Contains("Receptionist") || user.Contains("Security"))
            {
                InitializeComponent();
                if (user.Contains("Manager") || user.Contains("Receptionist"))
                {
                    startPage = true;
                    btnCheckAviableRooms.Visible = true;
                }
                if (user.Contains("Manager") || user.Contains("Security"))
                {
                    startPage = true;
                    btnSeePersonalInformations.Visible = true;
                    btnViewCheckInOut.Visible = true;
                }
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
        private void btnCheckAviableRooms_Click(object sender, EventArgs e)
        {
            Form temp = new CheckAviableRooms();
            openChildForm(temp);
        }

        private void btnSeePersonalInformations_Click(object sender, EventArgs e)
        {
            Form temp = new SeePersonalInformation();
            openChildForm(temp);
        }

        private void btnViewCheckInOut_Click(object sender, EventArgs e)
        {
            Form temp = new ViewCheckInOut();
            openChildForm(temp);
        }
    }
}

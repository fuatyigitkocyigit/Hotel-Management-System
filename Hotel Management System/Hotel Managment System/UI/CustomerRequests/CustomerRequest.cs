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
    public partial class CustomerRequest : Form
    {
        string user;
        public CustomerRequest(String user)
        {
            InitializeComponent();
            this.user = user;
            if (user.Contains("Manager") || user.Contains("Spa") || user.Contains("Chef"))
            {
                btnSpaRequest.Visible = true;
            }
            if (user.Contains("Manager") || user.Contains("Restaurant") || user.Contains("Chef"))
            {
                btnRestaurantRequest.Visible = true;
            }
            if (user.Contains("Manager") || user.Contains("Service") || user.Contains("Chef"))
            {
                btnRoomServiceRequests.Visible = true;
            }
            if (user.Contains("Manager") || user.Contains("Cleaning") || user.Contains("Chef"))
            {
                btnRoomCleaningRequests.Visible = true;
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

         private void btnSpaRequest_Click(object sender, EventArgs e)
        {
            Form temp = new SpaRequest();
            openChildForm(temp);
        }

        private void btnRestaurantRequest_Click(object sender, EventArgs e)
        {
            Form temp = new RestaurantRequest();
            openChildForm(temp);
        }

        private void btnRoomServiceRequests_Click(object sender, EventArgs e)
        {
            Form temp = new RoomServiceRequest();
            openChildForm(temp);
        }

        private void btnRoomCleaningRequests_Click(object sender, EventArgs e)
        {
            Form temp = new RoomCleaningRequest();
            openChildForm(temp);
        }
    }
}

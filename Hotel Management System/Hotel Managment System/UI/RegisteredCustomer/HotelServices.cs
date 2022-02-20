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
    public partial class HotelServices : Form
    {
        public HotelServices()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            pnlMakeReservation.Visible = false;
            pnlRequestRoomServiceSubMenu.Visible = false;
        }
        
        private void hideMenu()
        {
            if(pnlRequestRoomServiceSubMenu.Visible == true)
            {
                pnlRequestRoomServiceSubMenu.Visible = false;
            }
            if(pnlMakeReservation.Visible == true)
            {
                pnlMakeReservation.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        private void btnRequestRoomService_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlRequestRoomServiceSubMenu);
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlMakeReservation);
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

        private void btnRestraunt_Click(object sender, EventArgs e)
        {

            Form temp = new ReservationSpaReq(btnRestraunt.Text);
            temp.Tag = sender;
            openChildForm(temp);
        }

        private void btnSpa_Click(object sender, EventArgs e)
        {
            Form temp = new ReservationSpaReq(btnSpa.Text);
            temp.Tag = sender;
            openChildForm(temp);
        }

        private void btnRoomCleaning_Click(object sender, EventArgs e)
        {
            Form temp = new RoomService(btnRoomCleaning.Text);
            openChildForm(temp);
        }

        private void btnRoomService_Click(object sender, EventArgs e)
        {
            Form temp = new RoomService(btnRoomService.Text);
            openChildForm(temp);
        }
    }
}

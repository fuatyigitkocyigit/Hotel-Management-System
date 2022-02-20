using Hotel_Managment_System.UI;
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
    public partial class Form1 : Form
    {
        public int UserProfile;
        private object activeButton = null;
        private Form activeForm = null;

        public Form1()
        {

            InitializeComponent();
            
        }


        public void AddPages()
        {
            MainPanel.Visible = true;
            LogOutbtn.Visible = true;
            btnReservation.Visible = false;

            Form[] array = { };
            switch (UserProfile)
            {
                case 1:
                    Form[] Customer = { new HotelServices(), new CustomerFeedBack() };
                    array = Customer;
                    break;
                case 2:
                    Form[] Worker = { new Payment(tbUserName.Text), new Shift(tbUserName.Text), new CustomerRequest(tbUserName.Text)
                    ,new ChechInOut(tbUserName.Text),new FeedBacks(tbUserName.Text)};
                    array = Worker;
                    break;
                case 3:
                    Form[] Chef = { new Payment(tbUserName.Text), new Shift(tbUserName.Text), new CustomerRequest(tbUserName.Text)
                    ,new FeedBacks(tbUserName.Text)};
                    array = Chef;
                    break;
                default:
                    break;
            }
            
            int i = 0;
            
            foreach (Form item in array)
            { 
                
                Button button = new Button();
                button.Tag = item;
                button.Text = item.Text;
                button.Font = new System.Drawing.Font("Lucida Fax", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = Color.White;
                button.Size = new Size(ButtonPanel.Width, 50);
                button.Location = new Point(0, 60*i+10);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                this.ButtonPanel.Controls.Add(button);
                button.Click += new EventHandler(this.PageButton_Click);
                i++;
            }

        }

        private void PageButton_Click(object sender, EventArgs e)
        {
            Button selectedBtn = sender as Button;
            Form selected = selectedBtn.Tag as Form;

            if (activeForm != null && activeButton != sender)
                activeForm.Visible = false;

            if (activeButton == sender)
                return;


            activeButton = sender;
            activeForm = selected;
            this.MainPanel.Controls.Clear();
            selected.TopLevel = false;
            selected.FormBorderStyle = FormBorderStyle.None;
            selected.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(selected);
            this.MainPanel.Tag = selected;
            selected.BringToFront();
            selected.Show();


        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Equals("1234") && tbUserName.Text.Equals("Customer"))
            {
                UserProfile = 1;
                MainScreen.Visible = false;
                AddPages();

            }
            else if (tbPassword.Text.Equals("1234") && 
                (tbUserName.Text.Contains("Worker") || tbUserName.Text.Contains("Manager")))
            {
                UserProfile = 2;
                MainScreen.Visible = false;
                
                AddPages();

            }
            else if (tbPassword.Text.Equals("1234") && tbUserName.Text.Contains("Chef"))
            {
                UserProfile = 3;
                MainScreen.Visible = false;
                
                AddPages();

            }

            else
                MessageBox.Show("Username or Password is wrong");

            
            tbUserName.Text = null;
            tbPassword.Text = null;
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            ButtonPanel.Controls.Clear();
            if(activeForm != null)
            activeForm.Close();

            MainScreen.Visible = true;
            MainPanel.Visible = false;
            LogOutbtn.Visible = false;
            btnReservation.Visible = true;
        }

        public void btnReservation_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            if (temp.Text.Equals("Reservation Request"))
            {
                Form selected = new CustomerReservation();

                activeButton = sender;
                activeForm = selected;
                this.MainPanel.Controls.Clear();
                selected.TopLevel = false;
                selected.FormBorderStyle = FormBorderStyle.None;
                selected.Dock = DockStyle.Fill;
                this.MainPanel.Controls.Add(selected);
                this.MainPanel.Tag = selected;
                selected.BringToFront();
                selected.Show();

                MainScreen.Visible = false;
                MainPanel.Visible = true;
                btnReservation.Text = "Log In";
            }
            else
            {

                activeForm.Close();
                MainScreen.Visible = true;
                btnReservation.Text = "Reservation Request";

            }



        }
    }
}

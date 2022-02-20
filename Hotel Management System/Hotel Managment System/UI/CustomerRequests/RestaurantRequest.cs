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
    public partial class RestaurantRequest : Form
    {
        public RestaurantRequest()
        {
            InitializeComponent();
            AddCustomer();
        }

        private void AddCustomer()
        {
            dgCustomerList.Columns[0].Name = "Customer Name";
            dgCustomerList.Columns[1].Name = "Customer Surname";
            dgCustomerList.Columns[2].Name = "Time";

            string[] Names = { "Fuat", "Fatih", "Hüseyin", "Eyüp" };
            string[] Surnames = { "Koçyiğit", "Yiğitel", "Bulut", "Başlı" };
            string[] Times = { "09.00", "11.00", "16.00", "17.00" };
            for (int i = 0; i < Names.Length; i++)
            {
                dgCustomerList.Rows.Add(Names[i], Surnames[i], Times[i]);

            }
        }

    }
}

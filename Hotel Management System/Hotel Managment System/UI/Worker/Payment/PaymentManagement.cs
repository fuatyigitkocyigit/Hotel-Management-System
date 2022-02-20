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
    public partial class PaymentManagement : Form
    {
        public PaymentManagement()
        {
            InitializeComponent();
            AddWorkers();
        }

        private void AddWorkers()
        {
            dgWorkerList.Columns[0].Name = "Name";
            dgWorkerList.Columns[1].Name = "Surname";
            dgWorkerList.Columns[2].Name = "Salary";

            string[] Names = { "Fuat", "Fatih", "Hüseyin", "Eyüp" };
            string[] Surnames = { "Koçyiğit", "Yiğitel", "Bulut", "Başlı" };
            string[] Payments = { "5000", "Yol+Yemek", "6000", "0.5" };
            for (int i = 0; i < Names.Length; i++)
            {
                dgWorkerList.Rows.Add(Names[i], Surnames[i], Payments[i]);

            }
        }
    }
}

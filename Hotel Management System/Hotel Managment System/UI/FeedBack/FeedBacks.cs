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
    public partial class FeedBacks : Form
    {
        string user;
        public FeedBacks(String user)
        {
            
            this.user = user;
            if (user.Contains("Manager") || user.Contains("Chef"))
            {
                InitializeComponent();
                AddFeedBacks();
            }
        }

        private void AddFeedBacks()
        {
            dgWorkerList.Columns[0].Name = "Name";
            dgWorkerList.Columns[1].Name = "Surname";
            dgWorkerList.Columns[2].Name = "FeedBack";

            string[] Names = { "Fuat", "Fatih", "Hüseyin", "Eyüp" };
            string[] Surnames = { "Koçyiğit", "Yiğitel", "Bulut", "Başlı" };
            string[] FeedBack = { "Awesome hotel", "Greate workers", "Sun Bathing <3", "Beds are so confortable" };
            for (int i = 0; i < Names.Length; i++)
            {
                dgWorkerList.Rows.Add(Names[i], Surnames[i], FeedBack[i]);

            }
        }
    }
}

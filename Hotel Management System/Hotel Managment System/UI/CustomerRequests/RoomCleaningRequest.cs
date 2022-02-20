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
    public partial class RoomCleaningRequest : Form
    {
        public RoomCleaningRequest()
        {
            InitializeComponent();
            AddRoom();
        }
        private void AddRoom()
        {
            dgRoomList.Columns[0].Name = "Room Number";
            dgRoomList.Columns[1].Name = "Time";


            string[] Numbers = { "235", "111", "455", "332" };

            string[] Times = { "09.00", "11.00", "16.00", "17.00" };
            for (int i = 0; i < Numbers.Length; i++)
            {
                dgRoomList.Rows.Add(Numbers[i], Times[i]);

            }
        }
    }
}

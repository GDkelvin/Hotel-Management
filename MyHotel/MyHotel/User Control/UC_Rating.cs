using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHotel.User_Control
{
    public partial class UC_Rating : UserControl
    {
        function fn = new function();
        string query;
        public UC_Rating()
        {
            InitializeComponent();
        }

        private void UC_Rating_Load(object sender, EventArgs e)
        {
            query = "SELECT ra.ratingid, c.cname AS CustomerName, r.roomNo AS RoomNumber, c.checkin AS check_in_date, ra.rating, ra.comment FROM customer c JOIN rooms r ON c.roomid = r.roomid JOIN rating ra ON c.cid = ra.cid ORDER BY ra.rating DESC; ";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}

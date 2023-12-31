using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHotel.User_Control
{
    public partial class UC_MonthlyReport : UserControl
    {
        DBMyHotelDataContext db = new DBMyHotelDataContext();
        public UC_MonthlyReport()
        {
            InitializeComponent();
            
        }
       
        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UC_MonthlyReport_Load(object sender, EventArgs e)
        {

        }
    }

    public class ReportData
    {
        public int Month { get; set; }
        public string RoomType { get; set; }
        public decimal Revenue { get; set; }
        public decimal Percentage { get; set; }
    }


}

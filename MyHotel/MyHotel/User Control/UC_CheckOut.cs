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
    public partial class UC_CheckOut : UserControl
    {
        function fn = new function();
        string query;
        public UC_CheckOut()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_CheckOut_Load(object sender, EventArgs e)
        {
            query = "select customer.cid, customer.cname, customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin,rooms.roomNo , rooms.roomType, rooms.bed, rooms.price, rooms.roomid from customer inner join rooms on customer.roomid = rooms.roomid where chekout= 'NO'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid, customer.cname, customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin,rooms.roomNo ,rooms.roomid, rooms.roomType, rooms.bed, rooms.price, rooms.roomid from customer inner join rooms on customer.roomid = rooms.roomid where cname like '" + txtName.Text + "%'and chekout = 'NO'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        int roomID;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCname.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text= guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                roomID = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells["roomid"].Value.ToString());
                
            }
        }
        //kiểm soát và hiển thị dữ liệu 
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(txtCname.Text != "")
        //Kiểm tra xem ô văn bản txtCname có chứa dữ liệu không trước khi tiếp tục thực hiện các thao tác check-out
            {
                if(MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string rating = txtRating.Text;
                    string comment = txtComment.Text;
                    string cdate = txtCheckoutDate.Text;

                    query = "UPDATE customer SET chekout = 'YES', checkout = '" + cdate + "' WHERE cid = " + id + "; " +
                            "UPDATE rooms SET booked = 'NO' WHERE roomNo = '" + txtRoom.Text + "'; \n"+
                            "INSERT INTO rating (roomid, cid, rating, comment) VALUES ('" + roomID + "', " + id + ", '" + rating + "', '" + comment + "'); ";

                    fn.setData(query, " Successfull");

                    //cập nhật bảng customer để đánh dấu khách hàng đã thanh toán
                    //và cập nhật bảng rooms để đánh dấu phòng đã được trả trống
                    UC_CheckOut_Load(this, null);
                    // hàm UC_CheckOut_Load để tải lại dữ liệu, có thể là dữ liệu khách hàng đã được cập nhật
                    clearAll();
                }
                else
                {
                    MessageBox.Show("There no customer to choose", "Inform box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void clearAll()
        {
            txtCname.Clear();
            txtName.Clear();
            txtRoom.Clear();
            txtCheckoutDate.ResetText();

        }

        private void UC_CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txtRoom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

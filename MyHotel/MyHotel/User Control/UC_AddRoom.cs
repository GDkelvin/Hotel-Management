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
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        DBMyHotelDataContext db = new DBMyHotelDataContext();
        string query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
            
            var roomList = (from room in db.rooms select room).ToList();
            
            dtGrViewRooms.DataSource = roomList;
            dtGridRoom2.DataSource = roomList;

            var roomId = (from room in db.rooms select room.roomNo).ToList();
            txtSearch.DataSource = roomId;

            List<RoomType> roomTypes = new List<RoomType>()
            {
                new RoomType { Name = "3 stars", Price = 150000 },
                new RoomType { Name = "4 stars", Price = 170000 },
                new RoomType { Name = "5 stars", Price = 200000 }
            };
            txtRoomType.DataSource = roomTypes;
            txtRoomType.DisplayMember = "Name";
            txtRoomTypeEdit.DataSource = roomTypes;
            txtRoomTypeEdit.DisplayMember = "Name";

            txtPrice.DataSource = roomTypes;
            txtPrice.DisplayMember = "Price";
            txtPriceEdit.DataSource = roomTypes;
            txtPriceEdit.DisplayMember = "Price";


        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if(txtBed.Text !="" && txtPrice.Text !="" && txtRoomType.Text !="" && txtRoomNo.Text != "")
            {
                string roomno = txtRoomNo.Text;
                string type = txtRoomType.Text;
                string bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                query = "insert into rooms (roomNo, roomType, bed, price) values ('"+roomno+"','"+type+ "','" + bed + "'," + price + ")";
                fn.setData(query, "Room Added");

                UC_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Please don't leave empty");
            }
        }
        public void clearAll()
        {
            txtRoomNo.Clear();
            txtRoomType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.SelectedIndex = -1 ;
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBMyHotelDataContext db = new DBMyHotelDataContext();
            var roomId = (string)txtSearch.SelectedValue;
            if (roomId != null)
            {
                var roomToDelete = db.rooms.Where(r => r.roomNo == roomId).SingleOrDefault();
                if (roomToDelete != null)
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete room {roomToDelete.roomNo}?", "Delete Room Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        db.rooms.DeleteOnSubmit(roomToDelete);
                        db.SubmitChanges();
                        txtSearch.DataSource = null;
                        var rooms = (from room in db.rooms select room.roomNo).ToList();
                        txtSearch.DataSource = rooms;
                        MessageBox.Show("Room deleted successfully.");
                        UC_AddRoom_Load(this, null);
                    }
                }
                else
                {
                    MessageBox.Show("Room not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a room to delete.");
            }
            
        }

        private void dtGridRoom2_SelectionChanged(object sender, EventArgs e)
        {
            if(dtGridRoom2.SelectedRows.Count > 0)
            {
                room rm = dtGridRoom2.SelectedRows[0].DataBoundItem as room;

                txtRoomNoEdit.Text = rm.roomNo.ToString();
                txtRoomTypeEdit.Text = rm.roomType.ToString();
                txtPriceEdit.Text = rm.price.ToString();
                txtBedEdit.Text = rm.bed.ToString();
            }
        }
        public void UpdateRoom(room rm)
        {
            using (var db = new DBMyHotelDataContext())
            {
                room rooms = db.rooms.Single(r => r.roomid == rm.roomid);
                rooms.roomType = rm.roomType;
                rooms.roomNo = rm.roomNo;
                rooms.price = rm.price;
                rooms.bed = rm.bed;
                
                db.SubmitChanges();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtGridRoom2.SelectedRows.Count > 0)
            {
                room rm = dtGridRoom2.SelectedRows[0].DataBoundItem as room;

                rm.roomNo = txtRoomNoEdit.Text;
                rm.roomType = txtRoomTypeEdit.Text;
                rm.price = long.Parse(txtPriceEdit.Text);
                rm.bed = txtBedEdit.Text;
                UpdateRoom(rm);
                MessageBox.Show("Updated successfully!");
                UC_AddRoom_Load(this, null);
            }
        }
    }
    public class RoomType
    {
        public string Name { get; set; }
        public Int64 Price { get; set; }
    }
}

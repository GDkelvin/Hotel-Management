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
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        String query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                LabelToSet.Text = (num + 1).ToString();
            }
        }

        private void btnRegisation_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                string name, gender, email, username, password;
                Int64 mobile;
                try
                {
                    name = txtName.Text;
                    mobile = Int64.Parse(txtMobile.Text);
                    gender = txtGender.Text;
                    email = txtEmail.Text;
                    username = txtUsername.Text;
                    password = txtPassword.Text;

                    query = "insert into employee (ename,mobile,gender,emailid,username,pass) values ('" + name + "'," + mobile + ",'" + gender + "','" + email + "','" + username + "','" + password + "')";
                    fn.setData(query, "Regisation success");

                    clearALL();
                    getMaxID();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

                
            }
        }
        private void clearALL()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployee(guna2DataGridView1);
            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView2);
            }
        }
        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.GetData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Are you sure", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid = " + txtID.Text + "";
                    fn.setData(query, " Information of employee is deleted");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }
        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearALL();
        }
    }
}

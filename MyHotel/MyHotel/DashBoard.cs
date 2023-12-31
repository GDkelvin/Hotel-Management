﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHotel
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnAddRoom.Left + 60;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
            
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

            uC_AddRoom1.Visible = false;
            uC_CustomerRes1.Visible = false;
            uC_CheckOut1.Visible = false;
            uC_CustomerDetail1.Visible = false;
            uC_Employee1.Visible = false;
            uC_CheckOut1.Visible = false;
            uC_Rating1.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void btnCustomerRes_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCustomerRes.Left + 30;
            uC_CustomerRes1.Visible = true;
            uC_CustomerRes1.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCheckOut.Left + 40;
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
        }

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            PanelMoving.Left= btnCustomerDetail.Left + 40;
            uC_CustomerDetail1.Visible = true;
            uC_CustomerDetail1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnEmployee.Left + 40;
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnRating.Left + 40;
            uC_Rating1.Visible = true;
            uC_Rating1.BringToFront();
        }
    }
}

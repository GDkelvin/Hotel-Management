
namespace MyHotel
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRating = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRes = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelMoving = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnMinisize = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.uC_Employee1 = new MyHotel.User_Control.UC_Employee();
            this.uC_CustomerDetail1 = new MyHotel.User_Control.UC_CustomerDetail();
            this.uC_CheckOut1 = new MyHotel.User_Control.UC_CheckOut();
            this.uC_CustomerRes1 = new _5.UC_CustomerRes();
            this.uC_AddRoom1 = new MyHotel.User_Control.UC_AddRoom();
            this.uC_Rating1 = new MyHotel.User_Control.UC_Rating();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnRating);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCustomerDetail);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnCustomerRes);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 130);
            this.panel1.TabIndex = 2;
            // 
            // btnRating
            // 
            this.btnRating.BorderRadius = 18;
            this.btnRating.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRating.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRating.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRating.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRating.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRating.FillColor = System.Drawing.Color.SlateBlue;
            this.btnRating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating.ForeColor = System.Drawing.Color.White;
            this.btnRating.Location = new System.Drawing.Point(878, 3);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(169, 116);
            this.btnRating.TabIndex = 5;
            this.btnRating.Text = "Rating";
            this.btnRating.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderRadius = 18;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.FillColor = System.Drawing.Color.SlateBlue;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(703, 3);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(169, 116);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomerDetail
            // 
            this.btnCustomerDetail.BorderRadius = 18;
            this.btnCustomerDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDetail.FillColor = System.Drawing.Color.SlateBlue;
            this.btnCustomerDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetail.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetail.Location = new System.Drawing.Point(528, 3);
            this.btnCustomerDetail.Name = "btnCustomerDetail";
            this.btnCustomerDetail.Size = new System.Drawing.Size(169, 116);
            this.btnCustomerDetail.TabIndex = 3;
            this.btnCustomerDetail.Text = "Customer Detail";
            this.btnCustomerDetail.Click += new System.EventHandler(this.btnCustomerDetail_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderRadius = 18;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.SlateBlue;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(353, 3);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(169, 116);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCustomerRes
            // 
            this.btnCustomerRes.BorderRadius = 18;
            this.btnCustomerRes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerRes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerRes.FillColor = System.Drawing.Color.SlateBlue;
            this.btnCustomerRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRes.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRes.Location = new System.Drawing.Point(178, 3);
            this.btnCustomerRes.Name = "btnCustomerRes";
            this.btnCustomerRes.Size = new System.Drawing.Size(169, 116);
            this.btnCustomerRes.TabIndex = 1;
            this.btnCustomerRes.Text = "Customer Registration";
            this.btnCustomerRes.Click += new System.EventHandler(this.btnCustomerRes_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 18;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.SlateBlue;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(3, 3);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(169, 116);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.uC_Rating1);
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.uC_CustomerDetail1);
            this.panel2.Controls.Add(this.uC_CheckOut1);
            this.panel2.Controls.Add(this.uC_CustomerRes1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(3, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1371, 614);
            this.panel2.TabIndex = 3;
            // 
            // PanelMoving
            // 
            this.PanelMoving.BackColor = System.Drawing.Color.White;
            this.PanelMoving.Location = new System.Drawing.Point(33, 148);
            this.PanelMoving.Name = "PanelMoving";
            this.PanelMoving.Size = new System.Drawing.Size(169, 11);
            this.PanelMoving.TabIndex = 4;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this;
            // 
            // btnMinisize
            // 
            this.btnMinisize.BackColor = System.Drawing.Color.White;
            this.btnMinisize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinisize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinisize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinisize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinisize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnMinisize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinisize.ForeColor = System.Drawing.Color.White;
            this.btnMinisize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinisize.Image")));
            this.btnMinisize.Location = new System.Drawing.Point(1329, 48);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(34, 30);
            this.btnMinisize.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1329, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            this.uC_Employee1.Location = new System.Drawing.Point(-2, -2);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1882, 852);
            this.uC_Employee1.TabIndex = 4;
            // 
            // uC_CustomerDetail1
            // 
            this.uC_CustomerDetail1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerDetail1.Location = new System.Drawing.Point(-2, -2);
            this.uC_CustomerDetail1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_CustomerDetail1.Name = "uC_CustomerDetail1";
            this.uC_CustomerDetail1.Size = new System.Drawing.Size(1412, 692);
            this.uC_CustomerDetail1.TabIndex = 3;
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_CheckOut1.Location = new System.Drawing.Point(-2, -2);
            this.uC_CheckOut1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(1412, 692);
            this.uC_CheckOut1.TabIndex = 2;
            // 
            // uC_CustomerRes1
            // 
            this.uC_CustomerRes1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRes1.Location = new System.Drawing.Point(-2, -2);
            this.uC_CustomerRes1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_CustomerRes1.Name = "uC_CustomerRes1";
            this.uC_CustomerRes1.Size = new System.Drawing.Size(1371, 614);
            this.uC_CustomerRes1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.ForeColor = System.Drawing.Color.Black;
            this.uC_AddRoom1.Location = new System.Drawing.Point(-2, -2);
            this.uC_AddRoom1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1882, 595);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // uC_Rating1
            // 
            this.uC_Rating1.BackColor = System.Drawing.Color.White;
            this.uC_Rating1.Location = new System.Drawing.Point(-2, -2);
            this.uC_Rating1.Name = "uC_Rating1";
            this.uC_Rating1.Size = new System.Drawing.Size(1300, 550);
            this.uC_Rating1.TabIndex = 5;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.PanelMoving);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinisize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnMinisize;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetail;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRes;
        private System.Windows.Forms.Panel PanelMoving;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private User_Control.UC_AddRoom uC_AddRoom1;
        private _5.UC_CustomerRes uC_CustomerRes1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private User_Control.UC_CheckOut uC_CheckOut1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private User_Control.UC_CustomerDetail uC_CustomerDetail1;
        private User_Control.UC_Employee uC_Employee1;
        private Guna.UI2.WinForms.Guna2Button btnRating;
        private User_Control.UC_Rating uC_Rating1;
    }
}
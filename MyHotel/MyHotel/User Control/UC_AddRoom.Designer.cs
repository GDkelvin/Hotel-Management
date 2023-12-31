
namespace MyHotel.User_Control
{
    partial class UC_AddRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.txtRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtGrViewRooms = new System.Windows.Forms.DataGridView();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBedEdit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.txtRoomTypeEdit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtRoomNoEdit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtGridRoom2 = new System.Windows.Forms.DataGridView();
            this.txtPrice = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPriceEdit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrViewRooms)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridRoom2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1467, 554);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPrice);
            this.tabPage1.Controls.Add(this.txtBed);
            this.tabPage1.Controls.Add(this.btnAddRoom);
            this.tabPage1.Controls.Add(this.txtRoomType);
            this.tabPage1.Controls.Add(this.txtRoomNo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1459, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Room";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBed
            // 
            this.txtBed.BackColor = System.Drawing.Color.Transparent;
            this.txtBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBed.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtBed.ForeColor = System.Drawing.Color.Black;
            this.txtBed.ItemHeight = 30;
            this.txtBed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.txtBed.Location = new System.Drawing.Point(902, 330);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(344, 36);
            this.txtBed.TabIndex = 20;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 18;
            this.btnAddRoom.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnAddRoom.BorderThickness = 1;
            this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.Black;
            this.btnAddRoom.Location = new System.Drawing.Point(1066, 450);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(180, 45);
            this.btnAddRoom.TabIndex = 19;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // txtRoomType
            // 
            this.txtRoomType.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomType.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtRoomType.ForeColor = System.Drawing.Color.Black;
            this.txtRoomType.ItemHeight = 30;
            this.txtRoomType.Location = new System.Drawing.Point(902, 147);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(344, 36);
            this.txtRoomType.TabIndex = 17;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo.DefaultText = "";
            this.txtRoomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo.Location = new System.Drawing.Point(902, 44);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.PasswordChar = '\0';
            this.txtRoomNo.PlaceholderText = "";
            this.txtRoomNo.SelectedText = "";
            this.txtRoomNo.Size = new System.Drawing.Size(344, 48);
            this.txtRoomNo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(898, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(898, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(898, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Room type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(898, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Room number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Room";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 490);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtGrViewRooms);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.guna2HtmlLabel2);
            this.tabPage2.Controls.Add(this.guna2HtmlLabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1459, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete Room";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtGrViewRooms
            // 
            this.dtGrViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrViewRooms.BackgroundColor = System.Drawing.Color.White;
            this.dtGrViewRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGrViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrViewRooms.Location = new System.Drawing.Point(6, 160);
            this.dtGrViewRooms.Name = "dtGrViewRooms";
            this.dtGrViewRooms.Size = new System.Drawing.Size(1447, 362);
            this.dtGrViewRooms.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 18;
            this.btnDelete.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnDelete.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnDelete.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(522, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.ItemHeight = 30;
            this.txtSearch.Items.AddRange(new object[] {
            "All Customer Details",
            "In Hotel Customer",
            "CheckOut Customer"});
            this.txtSearch.Location = new System.Drawing.Point(13, 107);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(483, 36);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 7;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(25, 67);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(45, 22);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Search";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(25, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(152, 30);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Delete Room";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtPriceEdit);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtBedEdit);
            this.tabPage3.Controls.Add(this.btnEdit);
            this.tabPage3.Controls.Add(this.txtRoomTypeEdit);
            this.tabPage3.Controls.Add(this.txtRoomNoEdit);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.dtGridRoom2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1459, 528);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit Room";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 28);
            this.label10.TabIndex = 31;
            this.label10.Text = "Edit Room";
            // 
            // txtBedEdit
            // 
            this.txtBedEdit.BackColor = System.Drawing.Color.Transparent;
            this.txtBedEdit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtBedEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBedEdit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBedEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBedEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtBedEdit.ForeColor = System.Drawing.Color.Black;
            this.txtBedEdit.ItemHeight = 30;
            this.txtBedEdit.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.txtBedEdit.Location = new System.Drawing.Point(900, 346);
            this.txtBedEdit.Name = "txtBedEdit";
            this.txtBedEdit.Size = new System.Drawing.Size(344, 36);
            this.txtBedEdit.TabIndex = 30;
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 18;
            this.btnEdit.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnEdit.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(1064, 466);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 45);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Edit Room";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtRoomTypeEdit
            // 
            this.txtRoomTypeEdit.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomTypeEdit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtRoomTypeEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRoomTypeEdit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomTypeEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomTypeEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtRoomTypeEdit.ForeColor = System.Drawing.Color.Black;
            this.txtRoomTypeEdit.ItemHeight = 30;
            this.txtRoomTypeEdit.Location = new System.Drawing.Point(900, 163);
            this.txtRoomTypeEdit.Name = "txtRoomTypeEdit";
            this.txtRoomTypeEdit.Size = new System.Drawing.Size(344, 36);
            this.txtRoomTypeEdit.TabIndex = 27;
            // 
            // txtRoomNoEdit
            // 
            this.txtRoomNoEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNoEdit.DefaultText = "";
            this.txtRoomNoEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomNoEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomNoEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNoEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNoEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNoEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNoEdit.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNoEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNoEdit.Location = new System.Drawing.Point(900, 60);
            this.txtRoomNoEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoomNoEdit.Name = "txtRoomNoEdit";
            this.txtRoomNoEdit.PasswordChar = '\0';
            this.txtRoomNoEdit.PlaceholderText = "";
            this.txtRoomNoEdit.SelectedText = "";
            this.txtRoomNoEdit.Size = new System.Drawing.Size(344, 48);
            this.txtRoomNoEdit.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(896, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(896, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Bed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(896, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Room type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(896, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Room number";
            // 
            // dtGridRoom2
            // 
            this.dtGridRoom2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridRoom2.BackgroundColor = System.Drawing.Color.White;
            this.dtGridRoom2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridRoom2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridRoom2.Location = new System.Drawing.Point(11, 59);
            this.dtGridRoom2.Name = "dtGridRoom2";
            this.dtGridRoom2.Size = new System.Drawing.Size(846, 490);
            this.dtGridRoom2.TabIndex = 21;
            this.dtGridRoom2.SelectionChanged += new System.EventHandler(this.dtGridRoom2_SelectionChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPrice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.ItemHeight = 30;
            this.txtPrice.Items.AddRange(new object[] {
            "3 stars",
            "4 stars",
            "5 stars"});
            this.txtPrice.Location = new System.Drawing.Point(902, 237);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(344, 36);
            this.txtPrice.TabIndex = 21;
            // 
            // txtPriceEdit
            // 
            this.txtPriceEdit.BackColor = System.Drawing.Color.Transparent;
            this.txtPriceEdit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtPriceEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPriceEdit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPriceEdit.ForeColor = System.Drawing.Color.Black;
            this.txtPriceEdit.ItemHeight = 30;
            this.txtPriceEdit.Items.AddRange(new object[] {
            "3 stars",
            "4 stars",
            "5 stars"});
            this.txtPriceEdit.Location = new System.Drawing.Point(900, 251);
            this.txtPriceEdit.Name = "txtPriceEdit";
            this.txtPriceEdit.Size = new System.Drawing.Size(344, 36);
            this.txtPriceEdit.TabIndex = 32;
            // 
            // UC_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UC_AddRoom";
            this.Size = new System.Drawing.Size(1882, 560);
            this.Load += new System.EventHandler(this.UC_AddRoom_Load);
            this.Enter += new System.EventHandler(this.UC_AddRoom_Enter);
            this.Leave += new System.EventHandler(this.UC_AddRoom_Leave);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrViewRooms)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridRoom2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2ComboBox txtBed;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2ComboBox txtRoomType;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtGrViewRooms;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2ComboBox txtSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox txtBedEdit;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2ComboBox txtRoomTypeEdit;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNoEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtGridRoom2;
        private Guna.UI2.WinForms.Guna2ComboBox txtPrice;
        private Guna.UI2.WinForms.Guna2ComboBox txtPriceEdit;
    }
}

namespace BanquetHallReservationSystem
{
    partial class FrmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainWindow));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAdministration = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReservation = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHallRegistration = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHotelRegistration = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCustomerRegistration = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSelectedWindow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelShowWin = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sidePanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidePanel.Controls.Add(this.btnDashboard);
            this.sidePanel.Controls.Add(this.button1);
            this.sidePanel.Controls.Add(this.lblDateTime);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Controls.Add(this.lblUserName);
            this.sidePanel.Controls.Add(this.btnAdministration);
            this.sidePanel.Controls.Add(this.btnReservation);
            this.sidePanel.Controls.Add(this.btnHallRegistration);
            this.sidePanel.Controls.Add(this.btnHotelRegistration);
            this.sidePanel.Controls.Add(this.btnCustomerRegistration);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(226, 564);
            this.sidePanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test Connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDateTime.Location = new System.Drawing.Point(3, 545);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(101, 17);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "Date and Time";
            this.lblDateTime.Click += new System.EventHandler(this.lblDateTime_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.Coral;
            this.logoPanel.Controls.Add(this.label1);
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Controls.Add(this.label3);
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(226, 79);
            this.logoPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(61, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hotell JS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(63, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Special time with JS";
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(3, 519);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(223, 25);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "LogedUser";
            this.lblUserName.Visible = false;
            // 
            // btnAdministration
            // 
            this.btnAdministration.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdministration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdministration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdministration.BorderRadius = 0;
            this.btnAdministration.ButtonText = "Administration";
            this.btnAdministration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministration.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdministration.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdministration.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdministration.Iconimage")));
            this.btnAdministration.Iconimage_right = null;
            this.btnAdministration.Iconimage_right_Selected = null;
            this.btnAdministration.Iconimage_Selected = null;
            this.btnAdministration.IconMarginLeft = 0;
            this.btnAdministration.IconMarginRight = 0;
            this.btnAdministration.IconRightVisible = true;
            this.btnAdministration.IconRightZoom = 0D;
            this.btnAdministration.IconVisible = true;
            this.btnAdministration.IconZoom = 90D;
            this.btnAdministration.IsTab = false;
            this.btnAdministration.Location = new System.Drawing.Point(0, 390);
            this.btnAdministration.Name = "btnAdministration";
            this.btnAdministration.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdministration.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAdministration.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdministration.selected = false;
            this.btnAdministration.Size = new System.Drawing.Size(226, 62);
            this.btnAdministration.TabIndex = 6;
            this.btnAdministration.Text = "Administration";
            this.btnAdministration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministration.Textcolor = System.Drawing.Color.White;
            this.btnAdministration.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministration.Click += new System.EventHandler(this.btnAdministration_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReservation.BorderRadius = 0;
            this.btnReservation.ButtonText = "Reservation";
            this.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservation.DisabledColor = System.Drawing.Color.Gray;
            this.btnReservation.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReservation.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReservation.Iconimage")));
            this.btnReservation.Iconimage_right = null;
            this.btnReservation.Iconimage_right_Selected = null;
            this.btnReservation.Iconimage_Selected = null;
            this.btnReservation.IconMarginLeft = 0;
            this.btnReservation.IconMarginRight = 0;
            this.btnReservation.IconRightVisible = true;
            this.btnReservation.IconRightZoom = 0D;
            this.btnReservation.IconVisible = true;
            this.btnReservation.IconZoom = 90D;
            this.btnReservation.IsTab = false;
            this.btnReservation.Location = new System.Drawing.Point(0, 328);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReservation.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReservation.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReservation.selected = false;
            this.btnReservation.Size = new System.Drawing.Size(226, 62);
            this.btnReservation.TabIndex = 5;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.Textcolor = System.Drawing.Color.White;
            this.btnReservation.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnHallRegistration
            // 
            this.btnHallRegistration.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHallRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHallRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHallRegistration.BorderRadius = 0;
            this.btnHallRegistration.ButtonText = "Hall Registration";
            this.btnHallRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHallRegistration.DisabledColor = System.Drawing.Color.Gray;
            this.btnHallRegistration.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHallRegistration.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHallRegistration.Iconimage")));
            this.btnHallRegistration.Iconimage_right = null;
            this.btnHallRegistration.Iconimage_right_Selected = null;
            this.btnHallRegistration.Iconimage_Selected = null;
            this.btnHallRegistration.IconMarginLeft = 0;
            this.btnHallRegistration.IconMarginRight = 0;
            this.btnHallRegistration.IconRightVisible = true;
            this.btnHallRegistration.IconRightZoom = 0D;
            this.btnHallRegistration.IconVisible = true;
            this.btnHallRegistration.IconZoom = 90D;
            this.btnHallRegistration.IsTab = false;
            this.btnHallRegistration.Location = new System.Drawing.Point(0, 266);
            this.btnHallRegistration.Name = "btnHallRegistration";
            this.btnHallRegistration.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHallRegistration.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHallRegistration.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHallRegistration.selected = false;
            this.btnHallRegistration.Size = new System.Drawing.Size(226, 62);
            this.btnHallRegistration.TabIndex = 4;
            this.btnHallRegistration.Text = "Hall Registration";
            this.btnHallRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHallRegistration.Textcolor = System.Drawing.Color.White;
            this.btnHallRegistration.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHallRegistration.Click += new System.EventHandler(this.btnHallRegistration_Click);
            // 
            // btnHotelRegistration
            // 
            this.btnHotelRegistration.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHotelRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHotelRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHotelRegistration.BorderRadius = 0;
            this.btnHotelRegistration.ButtonText = "Hotel Registration";
            this.btnHotelRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelRegistration.DisabledColor = System.Drawing.Color.Gray;
            this.btnHotelRegistration.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHotelRegistration.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHotelRegistration.Iconimage")));
            this.btnHotelRegistration.Iconimage_right = null;
            this.btnHotelRegistration.Iconimage_right_Selected = null;
            this.btnHotelRegistration.Iconimage_Selected = null;
            this.btnHotelRegistration.IconMarginLeft = 0;
            this.btnHotelRegistration.IconMarginRight = 0;
            this.btnHotelRegistration.IconRightVisible = true;
            this.btnHotelRegistration.IconRightZoom = 0D;
            this.btnHotelRegistration.IconVisible = true;
            this.btnHotelRegistration.IconZoom = 90D;
            this.btnHotelRegistration.IsTab = false;
            this.btnHotelRegistration.Location = new System.Drawing.Point(0, 204);
            this.btnHotelRegistration.Name = "btnHotelRegistration";
            this.btnHotelRegistration.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHotelRegistration.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHotelRegistration.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHotelRegistration.selected = false;
            this.btnHotelRegistration.Size = new System.Drawing.Size(226, 62);
            this.btnHotelRegistration.TabIndex = 3;
            this.btnHotelRegistration.Text = "Hotel Registration";
            this.btnHotelRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotelRegistration.Textcolor = System.Drawing.Color.White;
            this.btnHotelRegistration.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotelRegistration.Click += new System.EventHandler(this.btnHotelRegistration_Click);
            // 
            // btnCustomerRegistration
            // 
            this.btnCustomerRegistration.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCustomerRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCustomerRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerRegistration.BorderRadius = 0;
            this.btnCustomerRegistration.ButtonText = "Customer Registration";
            this.btnCustomerRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerRegistration.DisabledColor = System.Drawing.Color.Gray;
            this.btnCustomerRegistration.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCustomerRegistration.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCustomerRegistration.Iconimage")));
            this.btnCustomerRegistration.Iconimage_right = null;
            this.btnCustomerRegistration.Iconimage_right_Selected = null;
            this.btnCustomerRegistration.Iconimage_Selected = null;
            this.btnCustomerRegistration.IconMarginLeft = 0;
            this.btnCustomerRegistration.IconMarginRight = 0;
            this.btnCustomerRegistration.IconRightVisible = true;
            this.btnCustomerRegistration.IconRightZoom = 0D;
            this.btnCustomerRegistration.IconVisible = true;
            this.btnCustomerRegistration.IconZoom = 90D;
            this.btnCustomerRegistration.IsTab = false;
            this.btnCustomerRegistration.Location = new System.Drawing.Point(0, 142);
            this.btnCustomerRegistration.Name = "btnCustomerRegistration";
            this.btnCustomerRegistration.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCustomerRegistration.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCustomerRegistration.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.selected = false;
            this.btnCustomerRegistration.Size = new System.Drawing.Size(226, 62);
            this.btnCustomerRegistration.TabIndex = 2;
            this.btnCustomerRegistration.Text = "Customer Registration";
            this.btnCustomerRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerRegistration.Textcolor = System.Drawing.Color.White;
            this.btnCustomerRegistration.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRegistration.Click += new System.EventHandler(this.btnCustomerRegistration_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.topPanel.Controls.Add(this.bunifuFlatButton1);
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.lblSelectedWindow);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(226, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(701, 79);
            this.topPanel.TabIndex = 1;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Cyan;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton1.ButtonText = "X";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(678, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Cyan;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(25, 26);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "X";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblSelectedWindow
            // 
            this.lblSelectedWindow.AutoSize = true;
            this.lblSelectedWindow.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedWindow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedWindow.Location = new System.Drawing.Point(538, 52);
            this.lblSelectedWindow.Name = "lblSelectedWindow";
            this.lblSelectedWindow.Size = new System.Drawing.Size(48, 19);
            this.lblSelectedWindow.TabIndex = 0;
            this.lblSelectedWindow.Text = "@@@";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(110, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Banquet Hall Reservation System";
            // 
            // panelShowWin
            // 
            this.panelShowWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowWin.Location = new System.Drawing.Point(226, 79);
            this.panelShowWin.Name = "panelShowWin";
            this.panelShowWin.Size = new System.Drawing.Size(701, 485);
            this.panelShowWin.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "Dashboard";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 90D;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(0, 80);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(226, 62);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // FrmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(927, 564);
            this.Controls.Add(this.panelShowWin);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdministration;
        private Bunifu.Framework.UI.BunifuFlatButton btnReservation;
        private Bunifu.Framework.UI.BunifuFlatButton btnHallRegistration;
        private Bunifu.Framework.UI.BunifuFlatButton btnHotelRegistration;
        private Bunifu.Framework.UI.BunifuFlatButton btnCustomerRegistration;
        private System.Windows.Forms.Panel panelShowWin;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserName;
        private System.Windows.Forms.Label lblSelectedWindow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
    }
}
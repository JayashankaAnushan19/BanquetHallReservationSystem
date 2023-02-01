namespace BanquetHallReservationSystem
{
    partial class ucAdministration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAdministration));
            this.tabconAdmin = new System.Windows.Forms.TabControl();
            this.tabpagResCon = new System.Windows.Forms.TabPage();
            this.listBoxCompletedRes = new System.Windows.Forms.ListBox();
            this.listBoxHallID = new System.Windows.Forms.ListBox();
            this.listBoxPenResID = new System.Windows.Forms.ListBox();
            this.btnReset1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCheckRes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.chbxReviewCheRes = new System.Windows.Forms.CheckBox();
            this.tabpagUseCon = new System.Windows.Forms.TabPage();
            this.btnReset2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblResView = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.imgHelpCan = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblWarnMessage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancel1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCompRes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtResId = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabpageChangePass = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbNewPass = new System.Windows.Forms.CheckBox();
            this.chbCurrentPass = new System.Windows.Forms.CheckBox();
            this.btnCancel2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnChangePass = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtRetypeNewPass = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtNewPass = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtCurrentPass = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabpageSort = new System.Windows.Forms.TabPage();
            this.listBoxSortHallID = new System.Windows.Forms.ListBox();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.listBoxSortGuestNumber = new System.Windows.Forms.ListBox();
            this.lblSelectedSortMethod = new System.Windows.Forms.Label();
            this.tabconAdmin.SuspendLayout();
            this.tabpagResCon.SuspendLayout();
            this.tabpagUseCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHelpCan)).BeginInit();
            this.tabpageChangePass.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabpageSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabconAdmin
            // 
            this.tabconAdmin.Controls.Add(this.tabpagResCon);
            this.tabconAdmin.Controls.Add(this.tabpagUseCon);
            this.tabconAdmin.Controls.Add(this.tabpageChangePass);
            this.tabconAdmin.Controls.Add(this.tabpageSort);
            this.tabconAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabconAdmin.Location = new System.Drawing.Point(3, 3);
            this.tabconAdmin.Name = "tabconAdmin";
            this.tabconAdmin.SelectedIndex = 0;
            this.tabconAdmin.Size = new System.Drawing.Size(693, 491);
            this.tabconAdmin.TabIndex = 0;
            this.tabconAdmin.Click += new System.EventHandler(this.tabconAdmin_Click);
            // 
            // tabpagResCon
            // 
            this.tabpagResCon.Controls.Add(this.listBoxCompletedRes);
            this.tabpagResCon.Controls.Add(this.listBoxHallID);
            this.tabpagResCon.Controls.Add(this.listBoxPenResID);
            this.tabpagResCon.Controls.Add(this.btnReset1);
            this.tabpagResCon.Controls.Add(this.bunifuCustomLabel1);
            this.tabpagResCon.Controls.Add(this.btnCheckRes);
            this.tabpagResCon.Controls.Add(this.chbxReviewCheRes);
            this.tabpagResCon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpagResCon.Location = new System.Drawing.Point(4, 30);
            this.tabpagResCon.Name = "tabpagResCon";
            this.tabpagResCon.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagResCon.Size = new System.Drawing.Size(685, 457);
            this.tabpagResCon.TabIndex = 0;
            this.tabpagResCon.Text = "Reservation Control";
            this.tabpagResCon.UseVisualStyleBackColor = true;
            // 
            // listBoxCompletedRes
            // 
            this.listBoxCompletedRes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCompletedRes.FormattingEnabled = true;
            this.listBoxCompletedRes.ItemHeight = 17;
            this.listBoxCompletedRes.Location = new System.Drawing.Point(16, 234);
            this.listBoxCompletedRes.Name = "listBoxCompletedRes";
            this.listBoxCompletedRes.Size = new System.Drawing.Size(614, 123);
            this.listBoxCompletedRes.TabIndex = 39;
            // 
            // listBoxHallID
            // 
            this.listBoxHallID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHallID.FormattingEnabled = true;
            this.listBoxHallID.ItemHeight = 17;
            this.listBoxHallID.Location = new System.Drawing.Point(326, 88);
            this.listBoxHallID.Name = "listBoxHallID";
            this.listBoxHallID.Size = new System.Drawing.Size(304, 140);
            this.listBoxHallID.TabIndex = 37;
            // 
            // listBoxPenResID
            // 
            this.listBoxPenResID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPenResID.FormattingEnabled = true;
            this.listBoxPenResID.ItemHeight = 17;
            this.listBoxPenResID.Location = new System.Drawing.Point(16, 88);
            this.listBoxPenResID.Name = "listBoxPenResID";
            this.listBoxPenResID.Size = new System.Drawing.Size(304, 140);
            this.listBoxPenResID.TabIndex = 35;
            // 
            // btnReset1
            // 
            this.btnReset1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset1.BorderRadius = 0;
            this.btnReset1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnReset1.ButtonText = "Reset";
            this.btnReset1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset1.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset1.Iconimage = null;
            this.btnReset1.Iconimage_right = null;
            this.btnReset1.Iconimage_right_Selected = null;
            this.btnReset1.Iconimage_Selected = null;
            this.btnReset1.IconMarginLeft = 0;
            this.btnReset1.IconMarginRight = 0;
            this.btnReset1.IconRightVisible = false;
            this.btnReset1.IconRightZoom = 0D;
            this.btnReset1.IconVisible = false;
            this.btnReset1.IconZoom = 90D;
            this.btnReset1.IsTab = false;
            this.btnReset1.Location = new System.Drawing.Point(16, 390);
            this.btnReset1.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReset1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset1.selected = false;
            this.btnReset1.Size = new System.Drawing.Size(85, 54);
            this.btnReset1.TabIndex = 34;
            this.btnReset1.Text = "Reset";
            this.btnReset1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset1.Textcolor = System.Drawing.Color.White;
            this.btnReset1.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(11, 56);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(197, 25);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Matched reservations :-";
            // 
            // btnCheckRes
            // 
            this.btnCheckRes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCheckRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCheckRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckRes.BorderRadius = 0;
            this.btnCheckRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCheckRes.ButtonText = "Check Reservation";
            this.btnCheckRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckRes.DisabledColor = System.Drawing.Color.Gray;
            this.btnCheckRes.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckRes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCheckRes.Iconimage = null;
            this.btnCheckRes.Iconimage_right = null;
            this.btnCheckRes.Iconimage_right_Selected = null;
            this.btnCheckRes.Iconimage_Selected = null;
            this.btnCheckRes.IconMarginLeft = 0;
            this.btnCheckRes.IconMarginRight = 0;
            this.btnCheckRes.IconRightVisible = false;
            this.btnCheckRes.IconRightZoom = 0D;
            this.btnCheckRes.IconVisible = false;
            this.btnCheckRes.IconZoom = 90D;
            this.btnCheckRes.IsTab = false;
            this.btnCheckRes.Location = new System.Drawing.Point(260, 7);
            this.btnCheckRes.Margin = new System.Windows.Forms.Padding(6);
            this.btnCheckRes.Name = "btnCheckRes";
            this.btnCheckRes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCheckRes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCheckRes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCheckRes.selected = false;
            this.btnCheckRes.Size = new System.Drawing.Size(189, 43);
            this.btnCheckRes.TabIndex = 1;
            this.btnCheckRes.Text = "Check Reservation";
            this.btnCheckRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckRes.Textcolor = System.Drawing.Color.White;
            this.btnCheckRes.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckRes.Click += new System.EventHandler(this.btnCheckRes_Click);
            // 
            // chbxReviewCheRes
            // 
            this.chbxReviewCheRes.AutoSize = true;
            this.chbxReviewCheRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxReviewCheRes.Location = new System.Drawing.Point(16, 17);
            this.chbxReviewCheRes.Name = "chbxReviewCheRes";
            this.chbxReviewCheRes.Size = new System.Drawing.Size(235, 25);
            this.chbxReviewCheRes.TabIndex = 0;
            this.chbxReviewCheRes.Text = "Review Checked Reservations";
            this.chbxReviewCheRes.UseVisualStyleBackColor = true;
            this.chbxReviewCheRes.CheckedChanged += new System.EventHandler(this.chbxReviewCheRes_CheckedChanged);
            // 
            // tabpagUseCon
            // 
            this.tabpagUseCon.Controls.Add(this.btnReset2);
            this.tabpagUseCon.Controls.Add(this.lblLocation);
            this.tabpagUseCon.Controls.Add(this.lblResView);
            this.tabpagUseCon.Controls.Add(this.label2);
            this.tabpagUseCon.Controls.Add(this.label1);
            this.tabpagUseCon.Controls.Add(this.btnCheck);
            this.tabpagUseCon.Controls.Add(this.imgHelpCan);
            this.tabpagUseCon.Controls.Add(this.lblWarnMessage);
            this.tabpagUseCon.Controls.Add(this.bunifuThinButton21);
            this.tabpagUseCon.Controls.Add(this.btnCancel1);
            this.tabpagUseCon.Controls.Add(this.btnCompRes);
            this.tabpagUseCon.Controls.Add(this.txtResId);
            this.tabpagUseCon.Controls.Add(this.bunifuCustomLabel4);
            this.tabpagUseCon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpagUseCon.Location = new System.Drawing.Point(4, 30);
            this.tabpagUseCon.Name = "tabpagUseCon";
            this.tabpagUseCon.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagUseCon.Size = new System.Drawing.Size(685, 457);
            this.tabpagUseCon.TabIndex = 1;
            this.tabpagUseCon.Text = "Reservation Complete";
            this.tabpagUseCon.UseVisualStyleBackColor = true;
            // 
            // btnReset2
            // 
            this.btnReset2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset2.BorderRadius = 0;
            this.btnReset2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnReset2.ButtonText = "Reset";
            this.btnReset2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset2.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset2.Iconimage = null;
            this.btnReset2.Iconimage_right = null;
            this.btnReset2.Iconimage_right_Selected = null;
            this.btnReset2.Iconimage_Selected = null;
            this.btnReset2.IconMarginLeft = 0;
            this.btnReset2.IconMarginRight = 0;
            this.btnReset2.IconRightVisible = false;
            this.btnReset2.IconRightZoom = 0D;
            this.btnReset2.IconVisible = false;
            this.btnReset2.IconZoom = 90D;
            this.btnReset2.IsTab = false;
            this.btnReset2.Location = new System.Drawing.Point(19, 371);
            this.btnReset2.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReset2.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset2.selected = false;
            this.btnReset2.Size = new System.Drawing.Size(85, 54);
            this.btnReset2.TabIndex = 33;
            this.btnReset2.Text = "Reset";
            this.btnReset2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset2.Textcolor = System.Drawing.Color.White;
            this.btnReset2.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(300, 171);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(332, 24);
            this.lblLocation.TabIndex = 32;
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResView
            // 
            this.lblResView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResView.Location = new System.Drawing.Point(229, 109);
            this.lblResView.Name = "lblResView";
            this.lblResView.Size = new System.Drawing.Size(422, 112);
            this.lblResView.TabIndex = 29;
            this.lblResView.Text = "\r\n             Reservation \r\n                 Details";
            this.lblResView.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 112);
            this.label2.TabIndex = 31;
            this.label2.Text = ":\r\n:\r\n:\r\n:\r\n:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 112);
            this.label1.TabIndex = 30;
            this.label1.Text = "Reservation ID \r\nCustomer ID\r\nCustomer Name\r\nMatched hall Location\r\nNumber of Gue" +
    "sts";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(563, 49);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(88, 29);
            this.btnCheck.TabIndex = 28;
            this.btnCheck.Text = "Check";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // imgHelpCan
            // 
            this.imgHelpCan.BackColor = System.Drawing.Color.SeaGreen;
            this.imgHelpCan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgHelpCan.BackgroundImage")));
            this.imgHelpCan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgHelpCan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgHelpCan.Image = ((System.Drawing.Image)(resources.GetObject("imgHelpCan.Image")));
            this.imgHelpCan.ImageActive = null;
            this.imgHelpCan.InitialImage = null;
            this.imgHelpCan.Location = new System.Drawing.Point(581, 249);
            this.imgHelpCan.Name = "imgHelpCan";
            this.imgHelpCan.Size = new System.Drawing.Size(25, 27);
            this.imgHelpCan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHelpCan.TabIndex = 27;
            this.imgHelpCan.TabStop = false;
            this.imgHelpCan.Visible = false;
            this.imgHelpCan.Zoom = 10;
            this.imgHelpCan.Click += new System.EventHandler(this.imgHelpCan_Click);
            // 
            // lblWarnMessage
            // 
            this.lblWarnMessage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWarnMessage.Location = new System.Drawing.Point(104, 249);
            this.lblWarnMessage.Name = "lblWarnMessage";
            this.lblWarnMessage.Size = new System.Drawing.Size(477, 100);
            this.lblWarnMessage.TabIndex = 26;
            this.lblWarnMessage.Text = resources.GetString("lblWarnMessage.Text");
            this.lblWarnMessage.Visible = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuThinButton21.ButtonText = "Help Tip";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(284, 249);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(128, 100);
            this.bunifuThinButton21.TabIndex = 25;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel1.BorderRadius = 0;
            this.btnCancel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCancel1.ButtonText = "Cancel";
            this.btnCancel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel1.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel1.Iconimage = null;
            this.btnCancel1.Iconimage_right = null;
            this.btnCancel1.Iconimage_right_Selected = null;
            this.btnCancel1.Iconimage_Selected = null;
            this.btnCancel1.IconMarginLeft = 0;
            this.btnCancel1.IconMarginRight = 0;
            this.btnCancel1.IconRightVisible = false;
            this.btnCancel1.IconRightZoom = 0D;
            this.btnCancel1.IconVisible = false;
            this.btnCancel1.IconZoom = 90D;
            this.btnCancel1.IsTab = false;
            this.btnCancel1.Location = new System.Drawing.Point(219, 371);
            this.btnCancel1.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancel1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel1.selected = false;
            this.btnCancel1.Size = new System.Drawing.Size(168, 54);
            this.btnCancel1.TabIndex = 18;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel1.Textcolor = System.Drawing.Color.White;
            this.btnCancel1.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnCompRes
            // 
            this.btnCompRes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCompRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCompRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompRes.BorderRadius = 0;
            this.btnCompRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCompRes.ButtonText = "Complete Reservation";
            this.btnCompRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompRes.DisabledColor = System.Drawing.Color.Gray;
            this.btnCompRes.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompRes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCompRes.Iconimage = null;
            this.btnCompRes.Iconimage_right = null;
            this.btnCompRes.Iconimage_right_Selected = null;
            this.btnCompRes.Iconimage_Selected = null;
            this.btnCompRes.IconMarginLeft = 0;
            this.btnCompRes.IconMarginRight = 0;
            this.btnCompRes.IconRightVisible = false;
            this.btnCompRes.IconRightZoom = 0D;
            this.btnCompRes.IconVisible = false;
            this.btnCompRes.IconZoom = 90D;
            this.btnCompRes.IsTab = false;
            this.btnCompRes.Location = new System.Drawing.Point(415, 371);
            this.btnCompRes.Margin = new System.Windows.Forms.Padding(6);
            this.btnCompRes.Name = "btnCompRes";
            this.btnCompRes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCompRes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCompRes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCompRes.selected = false;
            this.btnCompRes.Size = new System.Drawing.Size(236, 54);
            this.btnCompRes.TabIndex = 17;
            this.btnCompRes.Text = "Complete Reservation";
            this.btnCompRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompRes.Textcolor = System.Drawing.Color.White;
            this.btnCompRes.TextFont = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnCompRes.Click += new System.EventHandler(this.btnCompRes_Click);
            // 
            // txtResId
            // 
            this.txtResId.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtResId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResId.Location = new System.Drawing.Point(191, 49);
            this.txtResId.Name = "txtResId";
            this.txtResId.Size = new System.Drawing.Size(366, 29);
            this.txtResId.TabIndex = 13;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(14, 49);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(132, 25);
            this.bunifuCustomLabel4.TabIndex = 12;
            this.bunifuCustomLabel4.Text = "Reservation ID";
            // 
            // tabpageChangePass
            // 
            this.tabpageChangePass.Controls.Add(this.panel1);
            this.tabpageChangePass.Controls.Add(this.pictureBox1);
            this.tabpageChangePass.Location = new System.Drawing.Point(4, 30);
            this.tabpageChangePass.Name = "tabpageChangePass";
            this.tabpageChangePass.Size = new System.Drawing.Size(685, 457);
            this.tabpageChangePass.TabIndex = 2;
            this.tabpageChangePass.Text = "User Manager";
            this.tabpageChangePass.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbNewPass);
            this.panel1.Controls.Add(this.chbCurrentPass);
            this.panel1.Controls.Add(this.btnCancel2);
            this.panel1.Controls.Add(this.btnChangePass);
            this.panel1.Controls.Add(this.txtRetypeNewPass);
            this.panel1.Controls.Add(this.txtNewPass);
            this.panel1.Controls.Add(this.txtCurrentPass);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Location = new System.Drawing.Point(25, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 304);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // chbNewPass
            // 
            this.chbNewPass.AutoSize = true;
            this.chbNewPass.Location = new System.Drawing.Point(588, 61);
            this.chbNewPass.Name = "chbNewPass";
            this.chbNewPass.Size = new System.Drawing.Size(68, 25);
            this.chbNewPass.TabIndex = 32;
            this.chbNewPass.Text = "Show";
            this.chbNewPass.UseVisualStyleBackColor = true;
            // 
            // chbCurrentPass
            // 
            this.chbCurrentPass.AutoSize = true;
            this.chbCurrentPass.Location = new System.Drawing.Point(588, 19);
            this.chbCurrentPass.Name = "chbCurrentPass";
            this.chbCurrentPass.Size = new System.Drawing.Size(68, 25);
            this.chbCurrentPass.TabIndex = 31;
            this.chbCurrentPass.Text = "Show";
            this.chbCurrentPass.UseVisualStyleBackColor = true;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel2.BorderRadius = 0;
            this.btnCancel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCancel2.ButtonText = "Cancel";
            this.btnCancel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel2.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel2.Iconimage = null;
            this.btnCancel2.Iconimage_right = null;
            this.btnCancel2.Iconimage_right_Selected = null;
            this.btnCancel2.Iconimage_Selected = null;
            this.btnCancel2.IconMarginLeft = 0;
            this.btnCancel2.IconMarginRight = 0;
            this.btnCancel2.IconRightVisible = false;
            this.btnCancel2.IconRightZoom = 0D;
            this.btnCancel2.IconVisible = false;
            this.btnCancel2.IconZoom = 90D;
            this.btnCancel2.IsTab = false;
            this.btnCancel2.Location = new System.Drawing.Point(170, 184);
            this.btnCancel2.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancel2.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel2.selected = false;
            this.btnCancel2.Size = new System.Drawing.Size(164, 54);
            this.btnCancel2.TabIndex = 30;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel2.Textcolor = System.Drawing.Color.White;
            this.btnCancel2.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnChangePass
            // 
            this.btnChangePass.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangePass.BorderRadius = 0;
            this.btnChangePass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnChangePass.ButtonText = "Change Password";
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.DisabledColor = System.Drawing.Color.Gray;
            this.btnChangePass.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChangePass.Iconimage = null;
            this.btnChangePass.Iconimage_right = null;
            this.btnChangePass.Iconimage_right_Selected = null;
            this.btnChangePass.Iconimage_Selected = null;
            this.btnChangePass.IconMarginLeft = 0;
            this.btnChangePass.IconMarginRight = 0;
            this.btnChangePass.IconRightVisible = false;
            this.btnChangePass.IconRightZoom = 0D;
            this.btnChangePass.IconVisible = false;
            this.btnChangePass.IconZoom = 90D;
            this.btnChangePass.IsTab = false;
            this.btnChangePass.Location = new System.Drawing.Point(346, 184);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(6);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChangePass.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnChangePass.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChangePass.selected = false;
            this.btnChangePass.Size = new System.Drawing.Size(236, 54);
            this.btnChangePass.TabIndex = 29;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangePass.Textcolor = System.Drawing.Color.White;
            this.btnChangePass.TextFont = new System.Drawing.Font("Segoe UI", 14.25F);
            // 
            // txtRetypeNewPass
            // 
            this.txtRetypeNewPass.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtRetypeNewPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypeNewPass.Location = new System.Drawing.Point(212, 111);
            this.txtRetypeNewPass.Name = "txtRetypeNewPass";
            this.txtRetypeNewPass.Size = new System.Drawing.Size(370, 29);
            this.txtRetypeNewPass.TabIndex = 28;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(212, 61);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(370, 29);
            this.txtNewPass.TabIndex = 27;
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCurrentPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.Location = new System.Drawing.Point(212, 17);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(370, 29);
            this.txtCurrentPass.TabIndex = 26;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 111);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(195, 25);
            this.bunifuCustomLabel2.TabIndex = 25;
            this.bunifuCustomLabel2.Text = "Retype New Password";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 61);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(134, 25);
            this.bunifuCustomLabel3.TabIndex = 24;
            this.bunifuCustomLabel3.Text = "New Password";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(3, 17);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(160, 25);
            this.bunifuCustomLabel5.TabIndex = 23;
            this.bunifuCustomLabel5.Text = "Current Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 112);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // tabpageSort
            // 
            this.tabpageSort.Controls.Add(this.lblSelectedSortMethod);
            this.tabpageSort.Controls.Add(this.listBoxSortGuestNumber);
            this.tabpageSort.Controls.Add(this.btnBubbleSort);
            this.tabpageSort.Controls.Add(this.btnSelectionSort);
            this.tabpageSort.Controls.Add(this.listBoxSortHallID);
            this.tabpageSort.Location = new System.Drawing.Point(4, 30);
            this.tabpageSort.Name = "tabpageSort";
            this.tabpageSort.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageSort.Size = new System.Drawing.Size(685, 457);
            this.tabpageSort.TabIndex = 3;
            this.tabpageSort.Text = "Sort";
            this.tabpageSort.UseVisualStyleBackColor = true;
            this.tabpageSort.Click += new System.EventHandler(this.tabpageSort_Click);
            // 
            // listBoxSortHallID
            // 
            this.listBoxSortHallID.FormattingEnabled = true;
            this.listBoxSortHallID.ItemHeight = 21;
            this.listBoxSortHallID.Location = new System.Drawing.Point(119, 111);
            this.listBoxSortHallID.Name = "listBoxSortHallID";
            this.listBoxSortHallID.Size = new System.Drawing.Size(277, 340);
            this.listBoxSortHallID.TabIndex = 0;
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(6, 6);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(146, 45);
            this.btnSelectionSort.TabIndex = 1;
            this.btnSelectionSort.Text = "Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(167, 6);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(146, 45);
            this.btnBubbleSort.TabIndex = 2;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // listBoxSortGuestNumber
            // 
            this.listBoxSortGuestNumber.FormattingEnabled = true;
            this.listBoxSortGuestNumber.ItemHeight = 21;
            this.listBoxSortGuestNumber.Location = new System.Drawing.Point(402, 111);
            this.listBoxSortGuestNumber.Name = "listBoxSortGuestNumber";
            this.listBoxSortGuestNumber.Size = new System.Drawing.Size(277, 340);
            this.listBoxSortGuestNumber.TabIndex = 3;
            // 
            // lblSelectedSortMethod
            // 
            this.lblSelectedSortMethod.AutoSize = true;
            this.lblSelectedSortMethod.Location = new System.Drawing.Point(207, 68);
            this.lblSelectedSortMethod.Name = "lblSelectedSortMethod";
            this.lblSelectedSortMethod.Size = new System.Drawing.Size(159, 21);
            this.lblSelectedSortMethod.TabIndex = 4;
            this.lblSelectedSortMethod.Text = "Selected Sort method";
            // 
            // ucAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabconAdmin);
            this.Name = "ucAdministration";
            this.Size = new System.Drawing.Size(699, 497);
            this.tabconAdmin.ResumeLayout(false);
            this.tabpagResCon.ResumeLayout(false);
            this.tabpagResCon.PerformLayout();
            this.tabpagUseCon.ResumeLayout(false);
            this.tabpagUseCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHelpCan)).EndInit();
            this.tabpageChangePass.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabpageSort.ResumeLayout(false);
            this.tabpageSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabconAdmin;
        private System.Windows.Forms.TabPage tabpagResCon;
        private System.Windows.Forms.TabPage tabpagUseCon;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCheckRes;
        private System.Windows.Forms.CheckBox chbxReviewCheRes;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCompRes;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtResId;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblWarnMessage;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.TabPage tabpageChangePass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton imgHelpCan;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbNewPass;
        private System.Windows.Forms.CheckBox chbCurrentPass;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnChangePass;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtRetypeNewPass;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNewPass;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCurrentPass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset1;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset2;
        private System.Windows.Forms.ListBox listBoxPenResID;
        private System.Windows.Forms.ListBox listBoxHallID;
        private System.Windows.Forms.ListBox listBoxCompletedRes;
        private System.Windows.Forms.TabPage tabpageSort;
        private System.Windows.Forms.ListBox listBoxSortGuestNumber;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.ListBox listBoxSortHallID;
        private System.Windows.Forms.Label lblSelectedSortMethod;
    }
}

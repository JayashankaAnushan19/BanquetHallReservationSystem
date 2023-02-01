namespace BanquetHallReservationSystem
{
    partial class ucReservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdCusView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtCusId = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblWarning = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNumberOfGuests = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnUpdateTable = new System.Windows.Forms.Button();
            this.lblResId = new System.Windows.Forms.Label();
            this.datetimeText = new System.Windows.Forms.DateTimePicker();
            this.lblResCusHotelID = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdCusView)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCusView
            // 
            this.grdCusView.AllowUserToAddRows = false;
            this.grdCusView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdCusView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCusView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdCusView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCusView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCusView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdCusView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCusView.DoubleBuffered = true;
            this.grdCusView.EnableHeadersVisualStyles = false;
            this.grdCusView.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.grdCusView.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.grdCusView.Location = new System.Drawing.Point(36, 219);
            this.grdCusView.Name = "grdCusView";
            this.grdCusView.ReadOnly = true;
            this.grdCusView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdCusView.Size = new System.Drawing.Size(632, 190);
            this.grdCusView.TabIndex = 18;
            this.grdCusView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCusView_CellClick);
            // 
            // txtCusId
            // 
            this.txtCusId.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCusId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusId.Location = new System.Drawing.Point(190, 32);
            this.txtCusId.Name = "txtCusId";
            this.txtCusId.Size = new System.Drawing.Size(478, 29);
            this.txtCusId.TabIndex = 14;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(31, 86);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(122, 25);
            this.bunifuCustomLabel2.TabIndex = 13;
            this.bunifuCustomLabel2.Text = "Hall Location";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 29);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(116, 25);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Customer ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(501, 426);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 42);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(328, 426);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(167, 42);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(155, 426);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 42);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(478, 29);
            this.comboBox1.TabIndex = 22;
            this.toolTip1.SetToolTip(this.comboBox1, "Select Entered Location.");
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Crimson;
            this.lblWarning.Location = new System.Drawing.Point(196, 63);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(155, 20);
            this.lblWarning.TabIndex = 23;
            this.lblWarning.Text = "* Select Customer ID *";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(36, 426);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 42);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNumberOfGuests
            // 
            this.txtNumberOfGuests.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNumberOfGuests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfGuests.Location = new System.Drawing.Point(190, 121);
            this.txtNumberOfGuests.Name = "txtNumberOfGuests";
            this.txtNumberOfGuests.Size = new System.Drawing.Size(478, 29);
            this.txtNumberOfGuests.TabIndex = 26;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(31, 121);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(162, 25);
            this.bunifuCustomLabel3.TabIndex = 25;
            this.bunifuCustomLabel3.Text = "Number of guests";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(31, 156);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(153, 25);
            this.bunifuCustomLabel4.TabIndex = 27;
            this.bunifuCustomLabel4.Text = "Reservation Date";
            // 
            // btnUpdateTable
            // 
            this.btnUpdateTable.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTable.Location = new System.Drawing.Point(531, 189);
            this.btnUpdateTable.Name = "btnUpdateTable";
            this.btnUpdateTable.Size = new System.Drawing.Size(137, 24);
            this.btnUpdateTable.TabIndex = 30;
            this.btnUpdateTable.Text = "Update Table and Hotel";
            this.btnUpdateTable.UseVisualStyleBackColor = true;
            this.btnUpdateTable.Click += new System.EventHandler(this.btnUpdateTable_Click);
            // 
            // lblResId
            // 
            this.lblResId.AutoSize = true;
            this.lblResId.Location = new System.Drawing.Point(80, 200);
            this.lblResId.Name = "lblResId";
            this.lblResId.Size = new System.Drawing.Size(45, 13);
            this.lblResId.TabIndex = 31;
            this.lblResId.Text = "lblResId";
            this.lblResId.Visible = false;
            // 
            // datetimeText
            // 
            this.datetimeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeText.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeText.Location = new System.Drawing.Point(190, 156);
            this.datetimeText.Name = "datetimeText";
            this.datetimeText.Size = new System.Drawing.Size(478, 29);
            this.datetimeText.TabIndex = 32;
            this.datetimeText.ValueChanged += new System.EventHandler(this.datetimeText_ValueChanged);
            // 
            // lblResCusHotelID
            // 
            this.lblResCusHotelID.AutoSize = true;
            this.lblResCusHotelID.Location = new System.Drawing.Point(231, 200);
            this.lblResCusHotelID.Name = "lblResCusHotelID";
            this.lblResCusHotelID.Size = new System.Drawing.Size(90, 13);
            this.lblResCusHotelID.TabIndex = 33;
            this.lblResCusHotelID.Text = "lblResCusHotelID";
            this.lblResCusHotelID.Visible = false;
            // 
            // ucReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblResCusHotelID);
            this.Controls.Add(this.datetimeText);
            this.Controls.Add(this.lblResId);
            this.Controls.Add(this.btnUpdateTable);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txtNumberOfGuests);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.grdCusView);
            this.Controls.Add(this.txtCusId);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "ucReservation";
            this.Size = new System.Drawing.Size(699, 497);
            ((System.ComponentModel.ISupportInitialize)(this.grdCusView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid grdCusView;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCusId;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblWarning;
        private System.Windows.Forms.Button btnClear;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNumberOfGuests;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Button btnUpdateTable;
        private System.Windows.Forms.Label lblResId;
        private System.Windows.Forms.DateTimePicker datetimeText;
        private System.Windows.Forms.Label lblResCusHotelID;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

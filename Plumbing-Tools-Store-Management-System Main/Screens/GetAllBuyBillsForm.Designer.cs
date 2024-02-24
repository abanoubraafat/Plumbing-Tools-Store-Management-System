namespace Plumbing_Tools_Store_Management_System_Main.Screens
{
    partial class GetAllBuyBillsForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeleteBillBtn = new System.Windows.Forms.Button();
            this.EditBillBtn = new System.Windows.Forms.Button();
            this.NewBillBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BothFilterLbl = new System.Windows.Forms.Label();
            this.FilterDateLbl = new System.Windows.Forms.Label();
            this.FilterSupplierLbl = new System.Windows.Forms.Label();
            this.CancelFilterDateBtn = new System.Windows.Forms.Button();
            this.CancelFilterSupplierBtn = new System.Windows.Forms.Button();
            this.FilterDateBtn = new System.Windows.Forms.Button();
            this.FilterSupplierBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SupplierCombo = new System.Windows.Forms.ComboBox();
            this.ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.header_panel = new System.Windows.Forms.Panel();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.header_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.DeleteBillBtn);
            this.groupBox3.Controls.Add(this.EditBillBtn);
            this.groupBox3.Controls.Add(this.NewBillBtn);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(65, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(937, 478);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تفاصيل الفواتير :";
            // 
            // DeleteBillBtn
            // 
            this.DeleteBillBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteBillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBillBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteBillBtn.ForeColor = System.Drawing.Color.Red;
            this.DeleteBillBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteBillBtn.Location = new System.Drawing.Point(175, 414);
            this.DeleteBillBtn.Name = "DeleteBillBtn";
            this.DeleteBillBtn.Size = new System.Drawing.Size(123, 34);
            this.DeleteBillBtn.TabIndex = 130;
            this.DeleteBillBtn.Text = "حذف فاتورة";
            this.DeleteBillBtn.UseVisualStyleBackColor = true;
            this.DeleteBillBtn.Click += new System.EventHandler(this.DeleteBillBtn_Click);
            // 
            // EditBillBtn
            // 
            this.EditBillBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditBillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBillBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.EditBillBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EditBillBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditBillBtn.Location = new System.Drawing.Point(377, 414);
            this.EditBillBtn.Name = "EditBillBtn";
            this.EditBillBtn.Size = new System.Drawing.Size(123, 34);
            this.EditBillBtn.TabIndex = 129;
            this.EditBillBtn.Text = "تعديل فاتورة";
            this.EditBillBtn.UseVisualStyleBackColor = true;
            this.EditBillBtn.Click += new System.EventHandler(this.EditBillBtn_Click);
            // 
            // NewBillBtn
            // 
            this.NewBillBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewBillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewBillBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.NewBillBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NewBillBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewBillBtn.Location = new System.Drawing.Point(574, 414);
            this.NewBillBtn.Name = "NewBillBtn";
            this.NewBillBtn.Size = new System.Drawing.Size(123, 34);
            this.NewBillBtn.TabIndex = 127;
            this.NewBillBtn.Text = "فاتورة جديدة";
            this.NewBillBtn.UseVisualStyleBackColor = true;
            this.NewBillBtn.Click += new System.EventHandler(this.NewBillBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(60, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(786, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "رقم الفاتورة";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "إسم المورد";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "تاريخ الفاتورة";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الخصم";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "إجمالي المدفوع";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "المنتجات";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ملاحظات الفاتورة";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BothFilterLbl);
            this.panel1.Controls.Add(this.FilterDateLbl);
            this.panel1.Controls.Add(this.FilterSupplierLbl);
            this.panel1.Controls.Add(this.CancelFilterDateBtn);
            this.panel1.Controls.Add(this.CancelFilterSupplierBtn);
            this.panel1.Controls.Add(this.FilterDateBtn);
            this.panel1.Controls.Add(this.FilterSupplierBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SupplierCombo);
            this.panel1.Controls.Add(this.ToDatePicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.FromDatePicker);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 665);
            this.panel1.TabIndex = 1;
            // 
            // BothFilterLbl
            // 
            this.BothFilterLbl.AutoSize = true;
            this.BothFilterLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BothFilterLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BothFilterLbl.Location = new System.Drawing.Point(259, 160);
            this.BothFilterLbl.Name = "BothFilterLbl";
            this.BothFilterLbl.Size = new System.Drawing.Size(496, 24);
            this.BothFilterLbl.TabIndex = 146;
            this.BothFilterLbl.Text = "يتم الآن البحث بإستخدام إسم المورد وتاريخ الشراء للإلغاء إضغط إلغاء";
            this.BothFilterLbl.Visible = false;
            // 
            // FilterDateLbl
            // 
            this.FilterDateLbl.AutoSize = true;
            this.FilterDateLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FilterDateLbl.Location = new System.Drawing.Point(292, 160);
            this.FilterDateLbl.Name = "FilterDateLbl";
            this.FilterDateLbl.Size = new System.Drawing.Size(408, 24);
            this.FilterDateLbl.TabIndex = 145;
            this.FilterDateLbl.Text = "يتم الآن البحث بإستخدام تاريخ الشراء للإلغاء إضغط إلغاء";
            this.FilterDateLbl.Visible = false;
            // 
            // FilterSupplierLbl
            // 
            this.FilterSupplierLbl.AutoSize = true;
            this.FilterSupplierLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterSupplierLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FilterSupplierLbl.Location = new System.Drawing.Point(292, 159);
            this.FilterSupplierLbl.Name = "FilterSupplierLbl";
            this.FilterSupplierLbl.Size = new System.Drawing.Size(400, 24);
            this.FilterSupplierLbl.TabIndex = 144;
            this.FilterSupplierLbl.Text = "يتم الآن البحث بإستخدام إسم المورد للإلغاء إضغط إلغاء";
            this.FilterSupplierLbl.Visible = false;
            // 
            // CancelFilterDateBtn
            // 
            this.CancelFilterDateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelFilterDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelFilterDateBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.CancelFilterDateBtn.ForeColor = System.Drawing.Color.Red;
            this.CancelFilterDateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelFilterDateBtn.Location = new System.Drawing.Point(201, 124);
            this.CancelFilterDateBtn.Name = "CancelFilterDateBtn";
            this.CancelFilterDateBtn.Size = new System.Drawing.Size(61, 27);
            this.CancelFilterDateBtn.TabIndex = 143;
            this.CancelFilterDateBtn.Text = "إلغاء";
            this.CancelFilterDateBtn.UseVisualStyleBackColor = true;
            this.CancelFilterDateBtn.Click += new System.EventHandler(this.CancelFilterDateBtn_Click);
            // 
            // CancelFilterSupplierBtn
            // 
            this.CancelFilterSupplierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelFilterSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelFilterSupplierBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.CancelFilterSupplierBtn.ForeColor = System.Drawing.Color.Red;
            this.CancelFilterSupplierBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelFilterSupplierBtn.Location = new System.Drawing.Point(442, 70);
            this.CancelFilterSupplierBtn.Name = "CancelFilterSupplierBtn";
            this.CancelFilterSupplierBtn.Size = new System.Drawing.Size(63, 27);
            this.CancelFilterSupplierBtn.TabIndex = 142;
            this.CancelFilterSupplierBtn.Text = "إلغاء";
            this.CancelFilterSupplierBtn.UseVisualStyleBackColor = true;
            this.CancelFilterSupplierBtn.Click += new System.EventHandler(this.CancelFilterSupplierBtn_Click);
            // 
            // FilterDateBtn
            // 
            this.FilterDateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterDateBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.FilterDateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.FilterDateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterDateBtn.Location = new System.Drawing.Point(279, 124);
            this.FilterDateBtn.Name = "FilterDateBtn";
            this.FilterDateBtn.Size = new System.Drawing.Size(69, 27);
            this.FilterDateBtn.TabIndex = 141;
            this.FilterDateBtn.Text = "إختيار";
            this.FilterDateBtn.UseVisualStyleBackColor = true;
            this.FilterDateBtn.Click += new System.EventHandler(this.FilterDateBtn_Click);
            // 
            // FilterSupplierBtn
            // 
            this.FilterSupplierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterSupplierBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.FilterSupplierBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.FilterSupplierBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterSupplierBtn.Location = new System.Drawing.Point(519, 70);
            this.FilterSupplierBtn.Name = "FilterSupplierBtn";
            this.FilterSupplierBtn.Size = new System.Drawing.Size(69, 27);
            this.FilterSupplierBtn.TabIndex = 140;
            this.FilterSupplierBtn.Text = "إختيار";
            this.FilterSupplierBtn.UseVisualStyleBackColor = true;
            this.FilterSupplierBtn.Click += new System.EventHandler(this.FilterSupplierBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(801, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 139;
            this.label2.Text = "اسم المورد :";
            // 
            // SupplierCombo
            // 
            this.SupplierCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SupplierCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SupplierCombo.FormattingEnabled = true;
            this.SupplierCombo.IntegralHeight = false;
            this.SupplierCombo.Location = new System.Drawing.Point(620, 70);
            this.SupplierCombo.Name = "SupplierCombo";
            this.SupplierCombo.Size = new System.Drawing.Size(175, 32);
            this.SupplierCombo.TabIndex = 138;
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDatePicker.Location = new System.Drawing.Point(373, 124);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.RightToLeftLayout = true;
            this.ToDatePicker.Size = new System.Drawing.Size(175, 32);
            this.ToDatePicker.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(554, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 136;
            this.label1.Text = "إلى :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(796, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 135;
            this.label7.Text = "في الفترة من :";
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDatePicker.Location = new System.Drawing.Point(620, 124);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.RightToLeftLayout = true;
            this.FromDatePicker.Size = new System.Drawing.Size(175, 32);
            this.FromDatePicker.TabIndex = 133;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(456, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 37);
            this.label10.TabIndex = 124;
            this.label10.Text = "فواتير المشتريات";
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.header_panel.Controls.Add(this.label10);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(8, 8);
            this.header_panel.Margin = new System.Windows.Forms.Padding(4);
            this.header_panel.Name = "header_panel";
            this.header_panel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.header_panel.Size = new System.Drawing.Size(1073, 57);
            this.header_panel.TabIndex = 148;
            // 
            // GetAllBuyBillsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1089, 681);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GetAllBuyBillsForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetAllBuyBills";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteBillBtn;
        private System.Windows.Forms.Button EditBillBtn;
        private System.Windows.Forms.Button NewBillBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DateTimePicker FromDatePicker;
        private System.Windows.Forms.DateTimePicker ToDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SupplierCombo;
        private System.Windows.Forms.Button FilterDateBtn;
        private System.Windows.Forms.Button FilterSupplierBtn;
        private System.Windows.Forms.Button CancelFilterSupplierBtn;
        private System.Windows.Forms.Button CancelFilterDateBtn;
        private System.Windows.Forms.Label FilterDateLbl;
        private System.Windows.Forms.Label FilterSupplierLbl;
        private System.Windows.Forms.Label BothFilterLbl;
        private System.Windows.Forms.Panel header_panel;
    }
}
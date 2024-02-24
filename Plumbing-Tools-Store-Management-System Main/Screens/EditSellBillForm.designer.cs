namespace Plumbing_Tools_Store_Management_System_Main.Screens
{
    partial class EditSellBillForm
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
            this.BillNoTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddByCodeBtn = new System.Windows.Forms.Button();
            this.AddByNameBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ProductCodeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchProductCombo = new System.Windows.Forms.ComboBox();
            this.BillNotesTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BillDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TotalDiscountTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RestoreAllBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteProductFromBillBtn = new System.Windows.Forms.Button();
            this.SaveBillBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BillNoTxt
            // 
            this.BillNoTxt.Location = new System.Drawing.Point(471, 34);
            this.BillNoTxt.Name = "BillNoTxt";
            this.BillNoTxt.ReadOnly = true;
            this.BillNoTxt.Size = new System.Drawing.Size(175, 27);
            this.BillNoTxt.TabIndex = 115;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddByCodeBtn);
            this.groupBox2.Controls.Add(this.AddByNameBtn);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ProductCodeTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SearchProductCombo);
            this.groupBox2.Location = new System.Drawing.Point(67, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "طرق الإدخال :";
            // 
            // AddByCodeBtn
            // 
            this.AddByCodeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddByCodeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddByCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddByCodeBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.AddByCodeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.AddByCodeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddByCodeBtn.Location = new System.Drawing.Point(409, 36);
            this.AddByCodeBtn.Name = "AddByCodeBtn";
            this.AddByCodeBtn.Size = new System.Drawing.Size(55, 27);
            this.AddByCodeBtn.TabIndex = 130;
            this.AddByCodeBtn.Text = "أضف";
            this.AddByCodeBtn.UseVisualStyleBackColor = true;
            this.AddByCodeBtn.Click += new System.EventHandler(this.AddByCodeBtn_Click);
            // 
            // AddByNameBtn
            // 
            this.AddByNameBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddByNameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddByNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddByNameBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.AddByNameBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.AddByNameBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddByNameBtn.Location = new System.Drawing.Point(55, 36);
            this.AddByNameBtn.Name = "AddByNameBtn";
            this.AddByNameBtn.Size = new System.Drawing.Size(55, 27);
            this.AddByNameBtn.TabIndex = 129;
            this.AddByNameBtn.Text = "أضف";
            this.AddByNameBtn.UseVisualStyleBackColor = true;
            this.AddByNameBtn.Click += new System.EventHandler(this.AddByNameBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(297, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 19);
            this.label9.TabIndex = 127;
            this.label9.Text = "بحث بالإسم :";
            // 
            // ProductCodeTxt
            // 
            this.ProductCodeTxt.Location = new System.Drawing.Point(470, 36);
            this.ProductCodeTxt.Name = "ProductCodeTxt";
            this.ProductCodeTxt.Size = new System.Drawing.Size(175, 27);
            this.ProductCodeTxt.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(683, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 124;
            this.label5.Text = "الباركود :";
            // 
            // SearchProductCombo
            // 
            this.SearchProductCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchProductCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SearchProductCombo.FormattingEnabled = true;
            this.SearchProductCombo.IntegralHeight = false;
            this.SearchProductCombo.Location = new System.Drawing.Point(116, 36);
            this.SearchProductCombo.Name = "SearchProductCombo";
            this.SearchProductCombo.Size = new System.Drawing.Size(175, 27);
            this.SearchProductCombo.TabIndex = 118;
            // 
            // BillNotesTxt
            // 
            this.BillNotesTxt.Location = new System.Drawing.Point(24, 81);
            this.BillNotesTxt.Name = "BillNotesTxt";
            this.BillNotesTxt.Size = new System.Drawing.Size(331, 27);
            this.BillNotesTxt.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(376, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 120;
            this.label3.Text = "ملاحظات :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(652, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 117;
            this.label1.Text = "تاريخ الفاتورة :";
            // 
            // BillDate
            // 
            this.BillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BillDate.Location = new System.Drawing.Point(471, 81);
            this.BillDate.Name = "BillDate";
            this.BillDate.RightToLeftLayout = true;
            this.BillDate.Size = new System.Drawing.Size(175, 27);
            this.BillDate.TabIndex = 116;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BillNotesTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BillDate);
            this.groupBox1.Controls.Add(this.BillNoTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(68, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البيانات الأساسية :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(661, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 114;
            this.label7.Text = "رقم الفاتورة :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 684);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(386, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 29);
            this.label10.TabIndex = 133;
            this.label10.Text = "فاتورة مبيعات";
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(2, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 42);
            this.button7.TabIndex = 132;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TotalDiscountTxt);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.TotalTxt);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(68, 561);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(753, 106);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تفاصيل الفاتورة :";
            // 
            // TotalDiscountTxt
            // 
            this.TotalDiscountTxt.Location = new System.Drawing.Point(514, 26);
            this.TotalDiscountTxt.Name = "TotalDiscountTxt";
            this.TotalDiscountTxt.Size = new System.Drawing.Size(175, 27);
            this.TotalDiscountTxt.TabIndex = 128;
            this.TotalDiscountTxt.TextChanged += new System.EventHandler(this.TotalDiscountTxt_TextChanged);
            this.TotalDiscountTxt.Leave += new System.EventHandler(this.TotalDiscountTxt_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(695, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 127;
            this.label8.Text = "الخصم :";
            // 
            // TotalTxt
            // 
            this.TotalTxt.Location = new System.Drawing.Point(514, 67);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.ReadOnly = true;
            this.TotalTxt.Size = new System.Drawing.Size(175, 27);
            this.TotalTxt.TabIndex = 126;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(41, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(448, 27);
            this.textBox3.TabIndex = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(695, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 124;
            this.label6.Text = "الإجمالي :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RestoreAllBtn);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.DeleteProductFromBillBtn);
            this.groupBox3.Controls.Add(this.SaveBillBtn);
            this.groupBox3.Location = new System.Drawing.Point(69, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(752, 278);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تفاصيل البضاعة :";
            // 
            // RestoreAllBtn
            // 
            this.RestoreAllBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestoreAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreAllBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.RestoreAllBtn.ForeColor = System.Drawing.Color.Red;
            this.RestoreAllBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RestoreAllBtn.Location = new System.Drawing.Point(84, 229);
            this.RestoreAllBtn.Name = "RestoreAllBtn";
            this.RestoreAllBtn.Size = new System.Drawing.Size(159, 34);
            this.RestoreAllBtn.TabIndex = 138;
            this.RestoreAllBtn.Text = "استرجاع كل المنتجات";
            this.RestoreAllBtn.UseVisualStyleBackColor = true;
            this.RestoreAllBtn.Click += new System.EventHandler(this.RestoreAllBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Qty,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(19, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 197);
            this.dataGridView1.TabIndex = 137;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "رقم الصنف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "إسم الصنف";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "التكلفة";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "الكمية";
            this.Qty.Name = "Qty";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "الإجمالي";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // DeleteProductFromBillBtn
            // 
            this.DeleteProductFromBillBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteProductFromBillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteProductFromBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProductFromBillBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteProductFromBillBtn.ForeColor = System.Drawing.Color.Red;
            this.DeleteProductFromBillBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteProductFromBillBtn.Location = new System.Drawing.Point(295, 229);
            this.DeleteProductFromBillBtn.Name = "DeleteProductFromBillBtn";
            this.DeleteProductFromBillBtn.Size = new System.Drawing.Size(159, 34);
            this.DeleteProductFromBillBtn.TabIndex = 136;
            this.DeleteProductFromBillBtn.Text = "حذف المنتج من الفاتورة";
            this.DeleteProductFromBillBtn.UseVisualStyleBackColor = true;
            this.DeleteProductFromBillBtn.Click += new System.EventHandler(this.DeleteProductFromBillBtn_Click);
            // 
            // SaveBillBtn
            // 
            this.SaveBillBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveBillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBillBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.SaveBillBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveBillBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBillBtn.Location = new System.Drawing.Point(522, 229);
            this.SaveBillBtn.Name = "SaveBillBtn";
            this.SaveBillBtn.Size = new System.Drawing.Size(123, 34);
            this.SaveBillBtn.TabIndex = 134;
            this.SaveBillBtn.Text = "حفظ الفاتورة";
            this.SaveBillBtn.UseVisualStyleBackColor = true;
            this.SaveBillBtn.Click += new System.EventHandler(this.SaveBillBtn_Click_1);
            // 
            // EditSellBillForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditSellBillForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellBill";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox BillNoTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ProductCodeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SearchProductCombo;
        private System.Windows.Forms.TextBox BillNotesTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker BillDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TotalDiscountTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DeleteProductFromBillBtn;
        private System.Windows.Forms.Button SaveBillBtn;
        private System.Windows.Forms.Button AddByNameBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button AddByCodeBtn;
        private System.Windows.Forms.Button RestoreAllBtn;
    }
}
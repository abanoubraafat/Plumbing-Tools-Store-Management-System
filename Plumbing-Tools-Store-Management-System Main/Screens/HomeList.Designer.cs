
namespace WindowsFormsApp1
{
    partial class HomeList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.timerdashboard = new System.Windows.Forms.Timer(this.components);
            this.SearchProductCombo = new System.Windows.Forms.ComboBox();
            this.AddByCodeBtn = new System.Windows.Forms.Button();
            this.AddByNameBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductCodeTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SaveProductBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Qty,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(72, 145);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(951, 320);
            this.dataGridView1.TabIndex = 133;
            // 
            // ID
            // 
            this.ID.HeaderText = "Column3";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "كود الصنف";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "إسم الصنف";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "التكلفة";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "الكمية";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "الإجمالي";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // DiscountTxt
            // 
            this.DiscountTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountTxt.Location = new System.Drawing.Point(196, 48);
            this.DiscountTxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DiscountTxt.Name = "DiscountTxt";
            this.DiscountTxt.Size = new System.Drawing.Size(289, 31);
            this.DiscountTxt.TabIndex = 128;
            this.DiscountTxt.TextChanged += new System.EventHandler(this.DiscountTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(519, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 23);
            this.label8.TabIndex = 127;
            this.label8.Text = "الخصم :";
            // 
            // TotalTxt
            // 
            this.TotalTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxt.Location = new System.Drawing.Point(196, 129);
            this.TotalTxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.ReadOnly = true;
            this.TotalTxt.Size = new System.Drawing.Size(289, 31);
            this.TotalTxt.TabIndex = 126;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(519, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 124;
            this.label6.Text = "الإجمالي :";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.DiscountTxt);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.TotalTxt);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(406, 477);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox4.Size = new System.Drawing.Size(617, 202);
            this.groupBox4.TabIndex = 136;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تفاصيل الفاتورة :";
            // 
            // SearchProductCombo
            // 
            this.SearchProductCombo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProductCombo.FormattingEnabled = true;
            this.SearchProductCombo.Location = new System.Drawing.Point(116, 15);
            this.SearchProductCombo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SearchProductCombo.Name = "SearchProductCombo";
            this.SearchProductCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchProductCombo.Size = new System.Drawing.Size(219, 31);
            this.SearchProductCombo.TabIndex = 134;
            // 
            // AddByCodeBtn
            // 
            this.AddByCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddByCodeBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddByCodeBtn.ForeColor = System.Drawing.Color.White;
            this.AddByCodeBtn.Location = new System.Drawing.Point(613, 10);
            this.AddByCodeBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AddByCodeBtn.Name = "AddByCodeBtn";
            this.AddByCodeBtn.Size = new System.Drawing.Size(101, 45);
            this.AddByCodeBtn.TabIndex = 133;
            this.AddByCodeBtn.Text = "أضف";
            this.AddByCodeBtn.UseVisualStyleBackColor = true;
            this.AddByCodeBtn.Click += new System.EventHandler(this.AddByCodeBtn_Click);
            // 
            // AddByNameBtn
            // 
            this.AddByNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddByNameBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddByNameBtn.ForeColor = System.Drawing.Color.White;
            this.AddByNameBtn.Location = new System.Drawing.Point(5, 10);
            this.AddByNameBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AddByNameBtn.Name = "AddByNameBtn";
            this.AddByNameBtn.Size = new System.Drawing.Size(101, 45);
            this.AddByNameBtn.TabIndex = 132;
            this.AddByNameBtn.Text = "أضف";
            this.AddByNameBtn.UseVisualStyleBackColor = true;
            this.AddByNameBtn.Click += new System.EventHandler(this.AddByNameBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.SearchProductCombo);
            this.panel1.Controls.Add(this.ProductCodeTxt);
            this.panel1.Controls.Add(this.AddByCodeBtn);
            this.panel1.Controls.Add(this.AddByNameBtn);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 60);
            this.panel1.TabIndex = 135;
            // 
            // ProductCodeTxt
            // 
            this.ProductCodeTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCodeTxt.Location = new System.Drawing.Point(724, 15);
            this.ProductCodeTxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ProductCodeTxt.Name = "ProductCodeTxt";
            this.ProductCodeTxt.Size = new System.Drawing.Size(219, 31);
            this.ProductCodeTxt.TabIndex = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(345, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(101, 23);
            this.label9.TabIndex = 127;
            this.label9.Text = "بحث بالإسم :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(953, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 124;
            this.label5.Text = "الباركود :";
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            // 
            // SaveProductBtn
            // 
            this.SaveProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveProductBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.SaveProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveProductBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveProductBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveProductBtn.Location = new System.Drawing.Point(72, 531);
            this.SaveProductBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SaveProductBtn.Name = "SaveProductBtn";
            this.SaveProductBtn.Size = new System.Drawing.Size(229, 93);
            this.SaveProductBtn.TabIndex = 134;
            this.SaveProductBtn.Text = "عرض الفاتورة";
            this.SaveProductBtn.UseVisualStyleBackColor = true;
            // 
            // HomeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveProductBtn);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "HomeList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productsBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox DiscountTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer timerdashboard;
        private System.Windows.Forms.ComboBox SearchProductCombo;
        private System.Windows.Forms.Button AddByCodeBtn;
        private System.Windows.Forms.Button AddByNameBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ProductCodeTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.Button SaveProductBtn;
    }
}


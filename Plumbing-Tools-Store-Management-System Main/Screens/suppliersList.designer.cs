
namespace project
{
    partial class suppliersList
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
            this.label1 = new System.Windows.Forms.Label();
            this.suppliers_dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletesupplier_Btn = new System.Windows.Forms.Button();
            this.updatesupplier_Btn = new System.Windows.Forms.Button();
            this.addsupplier_Btn = new System.Windows.Forms.Button();
            this.reloadsupplier_btn = new System.Windows.Forms.Button();
            this.search_Lbl = new System.Windows.Forms.Label();
            this.searchsupplier_Rxt = new System.Windows.Forms.TextBox();
            this.suppliersearch_Btn = new System.Windows.Forms.Button();
            this.header_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.suppliers_dataGridView)).BeginInit();
            this.header_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(474, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 35);
            this.label1.TabIndex = 142;
            this.label1.Text = "جميع الموردين";
            // 
            // suppliers_dataGridView
            // 
            this.suppliers_dataGridView.AllowUserToAddRows = false;
            this.suppliers_dataGridView.AllowUserToDeleteRows = false;
            this.suppliers_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.suppliers_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliers_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliers_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.suppliers_dataGridView.Location = new System.Drawing.Point(94, 165);
            this.suppliers_dataGridView.MultiSelect = false;
            this.suppliers_dataGridView.Name = "suppliers_dataGridView";
            this.suppliers_dataGridView.ReadOnly = true;
            this.suppliers_dataGridView.RowHeadersWidth = 51;
            this.suppliers_dataGridView.Size = new System.Drawing.Size(890, 425);
            this.suppliers_dataGridView.TabIndex = 141;
            this.suppliers_dataGridView.SelectionChanged += new System.EventHandler(this.suppliers_dataGridView_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
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
            this.Column3.HeaderText = "رقم التليفون";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "اسم الشركة";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "الملاحظات";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "العنوان";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // deletesupplier_Btn
            // 
            this.deletesupplier_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deletesupplier_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletesupplier_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletesupplier_Btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.deletesupplier_Btn.ForeColor = System.Drawing.Color.Red;
            this.deletesupplier_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletesupplier_Btn.Location = new System.Drawing.Point(128, 609);
            this.deletesupplier_Btn.Name = "deletesupplier_Btn";
            this.deletesupplier_Btn.Size = new System.Drawing.Size(153, 41);
            this.deletesupplier_Btn.TabIndex = 140;
            this.deletesupplier_Btn.Text = "حذف";
            this.deletesupplier_Btn.UseVisualStyleBackColor = true;
            this.deletesupplier_Btn.Click += new System.EventHandler(this.deletesupplier_Btn_Click);
            // 
            // updatesupplier_Btn
            // 
            this.updatesupplier_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updatesupplier_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatesupplier_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatesupplier_Btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.updatesupplier_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updatesupplier_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatesupplier_Btn.Location = new System.Drawing.Point(466, 609);
            this.updatesupplier_Btn.Name = "updatesupplier_Btn";
            this.updatesupplier_Btn.Size = new System.Drawing.Size(153, 41);
            this.updatesupplier_Btn.TabIndex = 139;
            this.updatesupplier_Btn.Text = "تعديل";
            this.updatesupplier_Btn.UseVisualStyleBackColor = true;
            this.updatesupplier_Btn.Click += new System.EventHandler(this.updatesupplier_Btn_Click);
            // 
            // addsupplier_Btn
            // 
            this.addsupplier_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addsupplier_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addsupplier_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addsupplier_Btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addsupplier_Btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.addsupplier_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addsupplier_Btn.Location = new System.Drawing.Point(795, 609);
            this.addsupplier_Btn.Name = "addsupplier_Btn";
            this.addsupplier_Btn.Size = new System.Drawing.Size(153, 41);
            this.addsupplier_Btn.TabIndex = 138;
            this.addsupplier_Btn.Text = "اضافة";
            this.addsupplier_Btn.UseVisualStyleBackColor = true;
            this.addsupplier_Btn.Click += new System.EventHandler(this.addsupplier_Btn_Click);
            // 
            // reloadsupplier_btn
            // 
            this.reloadsupplier_btn.BackColor = System.Drawing.Color.White;
            this.reloadsupplier_btn.BackgroundImage = global::Plumbing_Tools_Store_Management_System_Main.Properties.Resources.load;
            this.reloadsupplier_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reloadsupplier_btn.Image = global::Plumbing_Tools_Store_Management_System_Main.Properties.Resources.load;
            this.reloadsupplier_btn.Location = new System.Drawing.Point(128, 124);
            this.reloadsupplier_btn.Name = "reloadsupplier_btn";
            this.reloadsupplier_btn.Size = new System.Drawing.Size(36, 35);
            this.reloadsupplier_btn.TabIndex = 137;
            this.reloadsupplier_btn.UseVisualStyleBackColor = false;
            this.reloadsupplier_btn.Click += new System.EventHandler(this.reloadsupplier_btn_Click);
            // 
            // search_Lbl
            // 
            this.search_Lbl.AutoSize = true;
            this.search_Lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.search_Lbl.ForeColor = System.Drawing.Color.Black;
            this.search_Lbl.Location = new System.Drawing.Point(859, 107);
            this.search_Lbl.Name = "search_Lbl";
            this.search_Lbl.Size = new System.Drawing.Size(103, 24);
            this.search_Lbl.TabIndex = 135;
            this.search_Lbl.Text = ": بحث بالاسم";
            // 
            // searchsupplier_Rxt
            // 
            this.searchsupplier_Rxt.Location = new System.Drawing.Point(590, 104);
            this.searchsupplier_Rxt.Name = "searchsupplier_Rxt";
            this.searchsupplier_Rxt.Size = new System.Drawing.Size(263, 32);
            this.searchsupplier_Rxt.TabIndex = 144;
            // 
            // suppliersearch_Btn
            // 
            this.suppliersearch_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suppliersearch_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliersearch_Btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.suppliersearch_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.suppliersearch_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suppliersearch_Btn.Location = new System.Drawing.Point(493, 104);
            this.suppliersearch_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.suppliersearch_Btn.Name = "suppliersearch_Btn";
            this.suppliersearch_Btn.Size = new System.Drawing.Size(75, 32);
            this.suppliersearch_Btn.TabIndex = 147;
            this.suppliersearch_Btn.Text = "بحث";
            this.suppliersearch_Btn.UseVisualStyleBackColor = true;
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.header_panel.Controls.Add(this.label1);
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Margin = new System.Windows.Forms.Padding(4);
            this.header_panel.Name = "header_panel";
            this.header_panel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.header_panel.Size = new System.Drawing.Size(1359, 60);
            this.header_panel.TabIndex = 148;
            // 
            // suppliersList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 681);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.suppliersearch_Btn);
            this.Controls.Add(this.searchsupplier_Rxt);
            this.Controls.Add(this.suppliers_dataGridView);
            this.Controls.Add(this.deletesupplier_Btn);
            this.Controls.Add(this.updatesupplier_Btn);
            this.Controls.Add(this.addsupplier_Btn);
            this.Controls.Add(this.reloadsupplier_btn);
            this.Controls.Add(this.search_Lbl);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "suppliersList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "suppliersList";
            ((System.ComponentModel.ISupportInitialize)(this.suppliers_dataGridView)).EndInit();
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView suppliers_dataGridView;
        private System.Windows.Forms.Button deletesupplier_Btn;
        private System.Windows.Forms.Button updatesupplier_Btn;
        private System.Windows.Forms.Button addsupplier_Btn;
        private System.Windows.Forms.Button reloadsupplier_btn;
        private System.Windows.Forms.Label search_Lbl;
        private System.Windows.Forms.TextBox searchsupplier_Rxt;
        private System.Windows.Forms.Button suppliersearch_Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel header_panel;
    }
}
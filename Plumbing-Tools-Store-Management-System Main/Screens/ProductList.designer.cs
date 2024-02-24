
namespace project
{
    partial class ProductList
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
            this.addproduct_Btn = new System.Windows.Forms.Button();
            this.updateproduct_Btn = new System.Windows.Forms.Button();
            this.deleteproduct_Btn = new System.Windows.Forms.Button();
            this.product_dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloadproduct_btn = new System.Windows.Forms.Button();
            this.searchproduct_Rxt = new System.Windows.Forms.TextBox();
            this.productsearch_Btn = new System.Windows.Forms.Button();
            this.header_panel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_dataGridView)).BeginInit();
            this.header_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addproduct_Btn
            // 
            this.addproduct_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addproduct_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addproduct_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addproduct_Btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addproduct_Btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.addproduct_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addproduct_Btn.Location = new System.Drawing.Point(780, 615);
            this.addproduct_Btn.Name = "addproduct_Btn";
            this.addproduct_Btn.Size = new System.Drawing.Size(153, 41);
            this.addproduct_Btn.TabIndex = 117;
            this.addproduct_Btn.Text = "اضافة";
            this.addproduct_Btn.UseVisualStyleBackColor = true;
            this.addproduct_Btn.Click += new System.EventHandler(this.addproduct_Btn_Click);
            // 
            // updateproduct_Btn
            // 
            this.updateproduct_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateproduct_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateproduct_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateproduct_Btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.updateproduct_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updateproduct_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateproduct_Btn.Location = new System.Drawing.Point(450, 615);
            this.updateproduct_Btn.Name = "updateproduct_Btn";
            this.updateproduct_Btn.Size = new System.Drawing.Size(153, 41);
            this.updateproduct_Btn.TabIndex = 118;
            this.updateproduct_Btn.Text = "تعديل";
            this.updateproduct_Btn.UseVisualStyleBackColor = true;
            this.updateproduct_Btn.Click += new System.EventHandler(this.updateproduct_Btn_Click);
            // 
            // deleteproduct_Btn
            // 
            this.deleteproduct_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteproduct_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteproduct_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteproduct_Btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.deleteproduct_Btn.ForeColor = System.Drawing.Color.Red;
            this.deleteproduct_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteproduct_Btn.Location = new System.Drawing.Point(139, 615);
            this.deleteproduct_Btn.Name = "deleteproduct_Btn";
            this.deleteproduct_Btn.Size = new System.Drawing.Size(153, 41);
            this.deleteproduct_Btn.TabIndex = 119;
            this.deleteproduct_Btn.Text = "حذف";
            this.deleteproduct_Btn.UseVisualStyleBackColor = true;
            this.deleteproduct_Btn.Click += new System.EventHandler(this.deleteproduct_Btn_Click);
            // 
            // product_dataGridView
            // 
            this.product_dataGridView.AllowUserToAddRows = false;
            this.product_dataGridView.AllowUserToDeleteRows = false;
            this.product_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.product_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.product_dataGridView.Location = new System.Drawing.Point(99, 153);
            this.product_dataGridView.MultiSelect = false;
            this.product_dataGridView.Name = "product_dataGridView";
            this.product_dataGridView.ReadOnly = true;
            this.product_dataGridView.RowHeadersWidth = 51;
            this.product_dataGridView.Size = new System.Drawing.Size(876, 441);
            this.product_dataGridView.TabIndex = 120;
            this.product_dataGridView.SelectionChanged += new System.EventHandler(this.product_dataGridView_SelectionChanged);
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
            this.Column2.HeaderText = "كود المنتج";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "إسم المنتج";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "السعر";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "الكمية";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // reloadproduct_btn
            // 
            this.reloadproduct_btn.BackColor = System.Drawing.Color.White;
            this.reloadproduct_btn.BackgroundImage = global::Plumbing_Tools_Store_Management_System_Main.Properties.Resources.load;
            this.reloadproduct_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reloadproduct_btn.Image = global::Plumbing_Tools_Store_Management_System_Main.Properties.Resources.load;
            this.reloadproduct_btn.Location = new System.Drawing.Point(124, 112);
            this.reloadproduct_btn.Name = "reloadproduct_btn";
            this.reloadproduct_btn.Size = new System.Drawing.Size(41, 35);
            this.reloadproduct_btn.TabIndex = 7;
            this.reloadproduct_btn.UseVisualStyleBackColor = false;
            this.reloadproduct_btn.Click += new System.EventHandler(this.reloadproduct_btn_Click);
            // 
            // searchproduct_Rxt
            // 
            this.searchproduct_Rxt.Location = new System.Drawing.Point(580, 99);
            this.searchproduct_Rxt.Name = "searchproduct_Rxt";
            this.searchproduct_Rxt.Size = new System.Drawing.Size(263, 27);
            this.searchproduct_Rxt.TabIndex = 145;
            // 
            // productsearch_Btn
            // 
            this.productsearch_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsearch_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsearch_Btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.productsearch_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.productsearch_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsearch_Btn.Location = new System.Drawing.Point(483, 99);
            this.productsearch_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.productsearch_Btn.Name = "productsearch_Btn";
            this.productsearch_Btn.Size = new System.Drawing.Size(75, 32);
            this.productsearch_Btn.TabIndex = 146;
            this.productsearch_Btn.Text = "بحث";
            this.productsearch_Btn.UseVisualStyleBackColor = true;
            this.productsearch_Btn.Click += new System.EventHandler(this.productsearch_Btn_Click);
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.header_panel.Controls.Add(this.label10);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Margin = new System.Windows.Forms.Padding(4);
            this.header_panel.Name = "header_panel";
            this.header_panel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.header_panel.Size = new System.Drawing.Size(1089, 60);
            this.header_panel.TabIndex = 147;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(476, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 29);
            this.label10.TabIndex = 153;
            this.label10.Text = "جميع المنتجات";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(861, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 19);
            this.label9.TabIndex = 154;
            this.label9.Text = "بحث بالإسم :";
            // 
            // ProductList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 681);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.productsearch_Btn);
            this.Controls.Add(this.searchproduct_Rxt);
            this.Controls.Add(this.product_dataGridView);
            this.Controls.Add(this.deleteproduct_Btn);
            this.Controls.Add(this.updateproduct_Btn);
            this.Controls.Add(this.addproduct_Btn);
            this.Controls.Add(this.reloadproduct_btn);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ProductList";
            ((System.ComponentModel.ISupportInitialize)(this.product_dataGridView)).EndInit();
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reloadproduct_btn;
        private System.Windows.Forms.Button addproduct_Btn;
        private System.Windows.Forms.Button updateproduct_Btn;
        private System.Windows.Forms.Button deleteproduct_Btn;
        private System.Windows.Forms.DataGridView product_dataGridView;
        private System.Windows.Forms.TextBox searchproduct_Rxt;
        private System.Windows.Forms.Button productsearch_Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}
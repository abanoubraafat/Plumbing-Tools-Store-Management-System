
namespace AddProduct.Screens
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.dashboard_panel = new System.Windows.Forms.Panel();
            this.buybills_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sellbills_Btn = new System.Windows.Forms.Button();
            this.home_Btn = new System.Windows.Forms.Button();
            this.products_Btn = new System.Windows.Forms.Button();
            this.suppliers_Btn = new System.Windows.Forms.Button();
            this.timerdashboard = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashboard_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboard_panel
            // 
            this.dashboard_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.dashboard_panel.Controls.Add(this.buybills_Btn);
            this.dashboard_panel.Controls.Add(this.pictureBox1);
            this.dashboard_panel.Controls.Add(this.button2);
            this.dashboard_panel.Controls.Add(this.sellbills_Btn);
            this.dashboard_panel.Controls.Add(this.home_Btn);
            this.dashboard_panel.Controls.Add(this.products_Btn);
            this.dashboard_panel.Controls.Add(this.suppliers_Btn);
            this.dashboard_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboard_panel.Location = new System.Drawing.Point(0, 0);
            this.dashboard_panel.Name = "dashboard_panel";
            this.dashboard_panel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dashboard_panel.Size = new System.Drawing.Size(252, 749);
            this.dashboard_panel.TabIndex = 40;
            // 
            // buybills_Btn
            // 
            this.buybills_Btn.FlatAppearance.BorderSize = 0;
            this.buybills_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buybills_Btn.ForeColor = System.Drawing.Color.White;
            this.buybills_Btn.Image = global::Plumbing_Tools_Store_Management_System_Main.Properties.Resources.receipt;
            this.buybills_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buybills_Btn.Location = new System.Drawing.Point(1, 552);
            this.buybills_Btn.Name = "buybills_Btn";
            this.buybills_Btn.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.buybills_Btn.Size = new System.Drawing.Size(251, 70);
            this.buybills_Btn.TabIndex = 135;
            this.buybills_Btn.Text = "فواتير المشتريات";
            this.buybills_Btn.UseVisualStyleBackColor = true;
            this.buybills_Btn.Click += new System.EventHandler(this.buybills_Btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Plumbing_Tools_Store_Management_System_Main.Properties.Resources.plumbing_services_logo;
            this.pictureBox1.Location = new System.Drawing.Point(19, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 134;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 44);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sellbills_Btn
            // 
            this.sellbills_Btn.FlatAppearance.BorderSize = 0;
            this.sellbills_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellbills_Btn.ForeColor = System.Drawing.Color.White;
            this.sellbills_Btn.Image = global::Plumbing_Tools_Store_Management_System_Main.Properties.Resources.receipt;
            this.sellbills_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sellbills_Btn.Location = new System.Drawing.Point(-2, 476);
            this.sellbills_Btn.Name = "sellbills_Btn";
            this.sellbills_Btn.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.sellbills_Btn.Size = new System.Drawing.Size(251, 70);
            this.sellbills_Btn.TabIndex = 5;
            this.sellbills_Btn.Text = "فواتير المبيعات";
            this.sellbills_Btn.UseVisualStyleBackColor = true;
            this.sellbills_Btn.Click += new System.EventHandler(this.sellbills_Btn_Click);
            // 
            // home_Btn
            // 
            this.home_Btn.FlatAppearance.BorderSize = 0;
            this.home_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_Btn.ForeColor = System.Drawing.Color.White;
            this.home_Btn.Image = global::Plumbing_Tools_Store_Management_System_Main.Properties.Resources.home;
            this.home_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_Btn.Location = new System.Drawing.Point(1, 248);
            this.home_Btn.Name = "home_Btn";
            this.home_Btn.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.home_Btn.Size = new System.Drawing.Size(251, 70);
            this.home_Btn.TabIndex = 1;
            this.home_Btn.Text = "الرئيسية";
            this.home_Btn.UseVisualStyleBackColor = true;
            this.home_Btn.Click += new System.EventHandler(this.home_Btn_Click);
            // 
            // products_Btn
            // 
            this.products_Btn.FlatAppearance.BorderSize = 0;
            this.products_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_Btn.ForeColor = System.Drawing.Color.White;
            this.products_Btn.Image = global::Plumbing_Tools_Store_Management_System_Main.Properties.Resources.cart;
            this.products_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.products_Btn.Location = new System.Drawing.Point(1, 324);
            this.products_Btn.Name = "products_Btn";
            this.products_Btn.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.products_Btn.Size = new System.Drawing.Size(251, 70);
            this.products_Btn.TabIndex = 2;
            this.products_Btn.Text = "المنتجات";
            this.products_Btn.UseVisualStyleBackColor = true;
            this.products_Btn.Click += new System.EventHandler(this.products_Btn_Click);
            // 
            // suppliers_Btn
            // 
            this.suppliers_Btn.FlatAppearance.BorderSize = 0;
            this.suppliers_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliers_Btn.ForeColor = System.Drawing.Color.White;
            this.suppliers_Btn.Image = global::Plumbing_Tools_Store_Management_System_Main.Properties.Resources.supliers;
            this.suppliers_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suppliers_Btn.Location = new System.Drawing.Point(1, 400);
            this.suppliers_Btn.Name = "suppliers_Btn";
            this.suppliers_Btn.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.suppliers_Btn.Size = new System.Drawing.Size(248, 70);
            this.suppliers_Btn.TabIndex = 4;
            this.suppliers_Btn.Text = "الموردين";
            this.suppliers_Btn.UseVisualStyleBackColor = true;
            this.suppliers_Btn.Click += new System.EventHandler(this.suppliers_Btn_Click);
            // 
            // timerdashboard
            // 
            this.timerdashboard.Tick += new System.EventHandler(this.timerdashboard_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(252, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 68);
            this.panel1.TabIndex = 41;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashboard_panel);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.dashboard_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dashboard_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sellbills_Btn;
        private System.Windows.Forms.Button home_Btn;
        private System.Windows.Forms.Button products_Btn;
        private System.Windows.Forms.Button suppliers_Btn;
        private System.Windows.Forms.Timer timerdashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buybills_Btn;
    }
}
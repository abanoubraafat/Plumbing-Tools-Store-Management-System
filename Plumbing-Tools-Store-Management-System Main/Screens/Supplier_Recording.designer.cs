namespace Plumbing_Tools_Store_Management_System_Main.Screens
{
    partial class Supplier_Recording
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
            this.SupID_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Notes_txt = new System.Windows.Forms.TextBox();
            this.SupAddress_txt = new System.Windows.Forms.TextBox();
            this.SupPhone_txt = new System.Windows.Forms.TextBox();
            this.SupName_txt = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Company_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(875, 102);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 130;
            this.label1.Text = "كود المورد:";
            // 
            // SupID_txt
            // 
            this.SupID_txt.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupID_txt.Location = new System.Drawing.Point(679, 99);
            this.SupID_txt.Name = "SupID_txt";
            this.SupID_txt.ReadOnly = true;
            this.SupID_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SupID_txt.Size = new System.Drawing.Size(190, 34);
            this.SupID_txt.TabIndex = 131;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 134;
            this.label4.Text = "اسم الشركة:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 135;
            this.label5.Text = "رقم التليفون:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(875, 183);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(103, 29);
            this.label7.TabIndex = 137;
            this.label7.Text = "اسم المورد:";
            // 
            // Notes_txt
            // 
            this.Notes_txt.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes_txt.Location = new System.Drawing.Point(679, 275);
            this.Notes_txt.Multiline = true;
            this.Notes_txt.Name = "Notes_txt";
            this.Notes_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Notes_txt.Size = new System.Drawing.Size(190, 86);
            this.Notes_txt.TabIndex = 138;
            // 
            // SupAddress_txt
            // 
            this.SupAddress_txt.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupAddress_txt.Location = new System.Drawing.Point(241, 272);
            this.SupAddress_txt.Name = "SupAddress_txt";
            this.SupAddress_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SupAddress_txt.Size = new System.Drawing.Size(190, 34);
            this.SupAddress_txt.TabIndex = 139;
            // 
            // SupPhone_txt
            // 
            this.SupPhone_txt.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupPhone_txt.Location = new System.Drawing.Point(241, 99);
            this.SupPhone_txt.Name = "SupPhone_txt";
            this.SupPhone_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SupPhone_txt.Size = new System.Drawing.Size(190, 34);
            this.SupPhone_txt.TabIndex = 142;
            this.SupPhone_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SupPhone_txt_KeyPress);
            this.SupPhone_txt.Leave += new System.EventHandler(this.SupPhone_txt_Leave);
            // 
            // SupName_txt
            // 
            this.SupName_txt.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupName_txt.Location = new System.Drawing.Point(679, 183);
            this.SupName_txt.Name = "SupName_txt";
            this.SupName_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SupName_txt.Size = new System.Drawing.Size(190, 34);
            this.SupName_txt.TabIndex = 143;
            this.SupName_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SupName_txt_KeyPress);
            // 
            // Save_btn
            // 
            this.Save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_btn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_btn.Location = new System.Drawing.Point(456, 414);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Save_btn.Size = new System.Drawing.Size(123, 46);
            this.Save_btn.TabIndex = 144;
            this.Save_btn.Text = "حفظ ";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Company_txt
            // 
            this.Company_txt.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company_txt.Location = new System.Drawing.Point(241, 183);
            this.Company_txt.Name = "Company_txt";
            this.Company_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Company_txt.Size = new System.Drawing.Size(190, 34);
            this.Company_txt.TabIndex = 147;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(884, 275);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 149;
            this.label3.Text = "الملاحظات:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 29);
            this.label6.TabIndex = 150;
            this.label6.Text = "العنوان:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Company_txt);
            this.panel3.Controls.Add(this.Save_btn);
            this.panel3.Controls.Add(this.SupName_txt);
            this.panel3.Controls.Add(this.SupPhone_txt);
            this.panel3.Controls.Add(this.SupAddress_txt);
            this.panel3.Controls.Add(this.Notes_txt);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.SupID_txt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1071, 574);
            this.panel3.TabIndex = 134;
            // 
<<<<<<< HEAD
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(410, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "تسجيل الموردين";
            // 
=======
>>>>>>> 66d8e18e83391142a8478dcfb4305f824f70337e
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1071, 60);
            this.panel1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(461, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 29);
            this.label10.TabIndex = 152;
            this.label10.Text = "إضافة مورد جديد";
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 42);
            this.button7.TabIndex = 151;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Supplier_Recording
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 634);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Supplier_Recording";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الموردين";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SupID_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Notes_txt;
        private System.Windows.Forms.TextBox SupAddress_txt;
        private System.Windows.Forms.TextBox SupPhone_txt;
        private System.Windows.Forms.TextBox SupName_txt;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.TextBox Company_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label10;
    }
}
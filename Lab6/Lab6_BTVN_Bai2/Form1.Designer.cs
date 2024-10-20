namespace Lab6_BTVN_Bai2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnQua2 = new System.Windows.Forms.Button();
            this.btnQua1 = new System.Windows.Forms.Button();
            this.btnChuyenQ2 = new System.Windows.Forms.Button();
            this.BtnChuyenQ1 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTongN2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTongN1 = new System.Windows.Forms.Label();
            this.listN1 = new System.Windows.Forms.ListBox();
            this.listN2 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtToolStripMenuItem,
            this.thoátChươngTrìnhToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cậpNhậtToolStripMenuItem.Text = "Cập Nhật";
            // 
            // thoátChươngTrìnhToolStripMenuItem
            // 
            this.thoátChươngTrìnhToolStripMenuItem.Name = "thoátChươngTrìnhToolStripMenuItem";
            this.thoátChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátChươngTrìnhToolStripMenuItem.Text = "Thoát Chương Trình";
            this.thoátChươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.thoátChươngTrìnhToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chương Trình Quản Lý Ca Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn Nhóm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập tên SV";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(162, 84);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(226, 32);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 31);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(463, 84);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(217, 32);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(463, 129);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(217, 32);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát Chương Trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnQua2
            // 
            this.btnQua2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQua2.Location = new System.Drawing.Point(297, 209);
            this.btnQua2.Name = "btnQua2";
            this.btnQua2.Size = new System.Drawing.Size(55, 38);
            this.btnQua2.TabIndex = 4;
            this.btnQua2.Text = ">";
            this.btnQua2.UseVisualStyleBackColor = true;
            this.btnQua2.Click += new System.EventHandler(this.btnQua2_Click);
            // 
            // btnQua1
            // 
            this.btnQua1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQua1.Location = new System.Drawing.Point(358, 209);
            this.btnQua1.Name = "btnQua1";
            this.btnQua1.Size = new System.Drawing.Size(53, 38);
            this.btnQua1.TabIndex = 4;
            this.btnQua1.Text = "<";
            this.btnQua1.UseVisualStyleBackColor = true;
            this.btnQua1.Click += new System.EventHandler(this.btnQua1_Click);
            // 
            // btnChuyenQ2
            // 
            this.btnChuyenQ2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenQ2.Location = new System.Drawing.Point(297, 253);
            this.btnChuyenQ2.Name = "btnChuyenQ2";
            this.btnChuyenQ2.Size = new System.Drawing.Size(55, 38);
            this.btnChuyenQ2.TabIndex = 4;
            this.btnChuyenQ2.Text = ">>";
            this.btnChuyenQ2.UseVisualStyleBackColor = true;
            this.btnChuyenQ2.Click += new System.EventHandler(this.btnChuyenQ2_Click);
            // 
            // BtnChuyenQ1
            // 
            this.BtnChuyenQ1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChuyenQ1.Location = new System.Drawing.Point(358, 253);
            this.BtnChuyenQ1.Name = "BtnChuyenQ1";
            this.BtnChuyenQ1.Size = new System.Drawing.Size(53, 38);
            this.BtnChuyenQ1.TabIndex = 4;
            this.BtnChuyenQ1.Text = "<<";
            this.BtnChuyenQ1.UseVisualStyleBackColor = true;
            this.BtnChuyenQ1.Click += new System.EventHandler(this.BtnChuyenQ1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(316, 383);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 38);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(297, 319);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 38);
            this.button6.TabIndex = 4;
            this.button6.Text = "<<>>";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.lbTongN2);
            this.panel1.Location = new System.Drawing.Point(446, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 43);
            this.panel1.TabIndex = 6;
            // 
            // lbTongN2
            // 
            this.lbTongN2.AutoSize = true;
            this.lbTongN2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongN2.Location = new System.Drawing.Point(3, 10);
            this.lbTongN2.Name = "lbTongN2";
            this.lbTongN2.Size = new System.Drawing.Size(117, 23);
            this.lbTongN2.TabIndex = 1;
            this.lbTongN2.Text = "Nhập tên SV";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.lbTongN1);
            this.panel2.Location = new System.Drawing.Point(48, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 43);
            this.panel2.TabIndex = 6;
            // 
            // lbTongN1
            // 
            this.lbTongN1.AutoSize = true;
            this.lbTongN1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongN1.Location = new System.Drawing.Point(3, 10);
            this.lbTongN1.Name = "lbTongN1";
            this.lbTongN1.Size = new System.Drawing.Size(117, 23);
            this.lbTongN1.TabIndex = 1;
            this.lbTongN1.Text = "Nhập tên SV";
            // 
            // listN1
            // 
            this.listN1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listN1.FormattingEnabled = true;
            this.listN1.ItemHeight = 23;
            this.listN1.Location = new System.Drawing.Point(28, 178);
            this.listN1.Name = "listN1";
            this.listN1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listN1.Size = new System.Drawing.Size(244, 234);
            this.listN1.TabIndex = 7;
            // 
            // listN2
            // 
            this.listN2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listN2.FormattingEnabled = true;
            this.listN2.ItemHeight = 23;
            this.listN2.Location = new System.Drawing.Point(436, 178);
            this.listN2.Name = "listN2";
            this.listN2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listN2.Size = new System.Drawing.Size(244, 234);
            this.listN2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 539);
            this.Controls.Add(this.listN2);
            this.Controls.Add(this.listN1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.BtnChuyenQ1);
            this.Controls.Add(this.btnQua1);
            this.Controls.Add(this.btnChuyenQ2);
            this.Controls.Add(this.btnQua2);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnQua2;
        private System.Windows.Forms.Button btnQua1;
        private System.Windows.Forms.Button btnChuyenQ2;
        private System.Windows.Forms.Button BtnChuyenQ1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTongN2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTongN1;
        private System.Windows.Forms.ListBox listN1;
        private System.Windows.Forms.ListBox listN2;
    }
}


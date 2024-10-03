namespace Bai3_vd
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCanh1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCanh3 = new System.Windows.Forms.TextBox();
            this.txtCanh2 = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdSTamGiac = new System.Windows.Forms.RadioButton();
            this.rdCTamGiac = new System.Windows.Forms.RadioButton();
            this.lbKQ = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính Chu Vi Và Diện Tích Tam Giác";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCanh2);
            this.groupBox1.Controls.Add(this.txtCanh3);
            this.groupBox1.Controls.Add(this.txtCanh1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtCanh1
            // 
            this.txtCanh1.Location = new System.Drawing.Point(245, 42);
            this.txtCanh1.Name = "txtCanh1";
            this.txtCanh1.Size = new System.Drawing.Size(100, 29);
            this.txtCanh1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập cạnh thứ nhất";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(441, 28);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(91, 36);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập cạnh thứ 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập số thứ 3";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCanh3
            // 
            this.txtCanh3.Location = new System.Drawing.Point(245, 120);
            this.txtCanh3.Name = "txtCanh3";
            this.txtCanh3.Size = new System.Drawing.Size(100, 29);
            this.txtCanh3.TabIndex = 0;
            // 
            // txtCanh2
            // 
            this.txtCanh2.Location = new System.Drawing.Point(245, 80);
            this.txtCanh2.Name = "txtCanh2";
            this.txtCanh2.Size = new System.Drawing.Size(100, 29);
            this.txtCanh2.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(441, 133);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 36);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdCTamGiac);
            this.groupBox2.Controls.Add(this.rdSTamGiac);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 98);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính";
            // 
            // rdSTamGiac
            // 
            this.rdSTamGiac.AutoSize = true;
            this.rdSTamGiac.Location = new System.Drawing.Point(79, 39);
            this.rdSTamGiac.Name = "rdSTamGiac";
            this.rdSTamGiac.Size = new System.Drawing.Size(176, 28);
            this.rdSTamGiac.TabIndex = 0;
            this.rdSTamGiac.TabStop = true;
            this.rdSTamGiac.Text = "Diện tích tam giác";
            this.rdSTamGiac.UseVisualStyleBackColor = true;
            this.rdSTamGiac.CheckedChanged += new System.EventHandler(this.rdSTamGiac_CheckedChanged);
            // 
            // rdCTamGiac
            // 
            this.rdCTamGiac.AutoSize = true;
            this.rdCTamGiac.Location = new System.Drawing.Point(345, 39);
            this.rdCTamGiac.Name = "rdCTamGiac";
            this.rdCTamGiac.Size = new System.Drawing.Size(156, 28);
            this.rdCTamGiac.TabIndex = 0;
            this.rdCTamGiac.TabStop = true;
            this.rdCTamGiac.Text = "Chu vi tam giác";
            this.rdCTamGiac.UseVisualStyleBackColor = true;
            this.rdCTamGiac.CheckedChanged += new System.EventHandler(this.rdCTamGiac_CheckedChanged);
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.Location = new System.Drawing.Point(49, 378);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(93, 24);
            this.lbKQ.TabIndex = 1;
            this.lbKQ.Text = "Kết Qủa : ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(441, 81);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 37);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKQ);
            this.Name = "Form1";
            this.Text = "Tính Chu Vi Và Diện Tích Tam Giác";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCanh2;
        private System.Windows.Forms.TextBox txtCanh3;
        private System.Windows.Forms.TextBox txtCanh1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdCTamGiac;
        private System.Windows.Forms.RadioButton rdSTamGiac;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Button btnReset;
    }
}


namespace Bai1_vd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTong = new TextBox();
            btnTinh = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // txtN
            // 
            txtN.Location = new Point(94, 26);
            txtN.Name = "txtN";
            txtN.Size = new Size(100, 23);
            txtN.TabIndex = 0;
            txtN.TextChanged += txtN_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 26);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Nhập n :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 66);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Tổng :";
            // 
            // txtTong
            // 
            txtTong.Location = new Point(94, 63);
            txtTong.Name = "txtTong";
            txtTong.Size = new Size(100, 23);
            txtTong.TabIndex = 0;
            txtTong.TextChanged += txtTong_TextChanged;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(27, 109);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(75, 23);
            btnTinh.TabIndex = 3;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(132, 109);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 163);
            Controls.Add(btnThoat);
            Controls.Add(btnTinh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTong);
            Controls.Add(txtN);
            Name = "Form1";
            Text = "BaiTap01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtN;
        private Label label1;
        private Label label2;
        private TextBox txtTong;
        private Button btnTinh;
        private Button btnThoat;
    }
}

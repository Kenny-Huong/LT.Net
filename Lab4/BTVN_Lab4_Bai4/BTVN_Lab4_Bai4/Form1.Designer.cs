namespace BTVN_Lab4_Bai4
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
            this.btnTang2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtN = new System.Windows.Forms.TextBox();
            this.grChucNang = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnChanDau = new System.Windows.Forms.Button();
            this.btnLeCuoi = new System.Windows.Forms.Button();
            this.btnXoaItem = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.listNumber = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.grChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên : ";
            // 
            // btnTang2
            // 
            this.btnTang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTang2.Location = new System.Drawing.Point(35, 45);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(240, 31);
            this.btnTang2.TabIndex = 2;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.listNumber);
            this.panel1.Controls.Add(this.btnKetThuc);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.grChucNang);
            this.panel1.Controls.Add(this.txtN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-18, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 447);
            this.panel1.TabIndex = 3;
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(218, 30);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(260, 31);
            this.txtN.TabIndex = 1;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // grChucNang
            // 
            this.grChucNang.Controls.Add(this.btnXoaCuoi);
            this.grChucNang.Controls.Add(this.btnXoaItem);
            this.grChucNang.Controls.Add(this.btnChanDau);
            this.grChucNang.Controls.Add(this.btnXoaDau);
            this.grChucNang.Controls.Add(this.btnLeCuoi);
            this.grChucNang.Controls.Add(this.btnTang2);
            this.grChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grChucNang.Location = new System.Drawing.Point(356, 86);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Size = new System.Drawing.Size(310, 292);
            this.grChucNang.TabIndex = 3;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Chức Năng";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(493, 30);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(115, 31);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnChanDau
            // 
            this.btnChanDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChanDau.Location = new System.Drawing.Point(35, 82);
            this.btnChanDau.Name = "btnChanDau";
            this.btnChanDau.Size = new System.Drawing.Size(240, 31);
            this.btnChanDau.TabIndex = 2;
            this.btnChanDau.Text = "Chọn số chẵn đầu";
            this.btnChanDau.UseVisualStyleBackColor = true;
            // 
            // btnLeCuoi
            // 
            this.btnLeCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeCuoi.Location = new System.Drawing.Point(35, 119);
            this.btnLeCuoi.Name = "btnLeCuoi";
            this.btnLeCuoi.Size = new System.Drawing.Size(240, 31);
            this.btnLeCuoi.TabIndex = 2;
            this.btnLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnLeCuoi.UseVisualStyleBackColor = true;
            // 
            // btnXoaItem
            // 
            this.btnXoaItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaItem.Location = new System.Drawing.Point(35, 156);
            this.btnXoaItem.Name = "btnXoaItem";
            this.btnXoaItem.Size = new System.Drawing.Size(240, 31);
            this.btnXoaItem.TabIndex = 2;
            this.btnXoaItem.Text = "Xóa phần tử đang chọn";
            this.btnXoaItem.UseVisualStyleBackColor = true;
            // 
            // btnXoaDau
            // 
            this.btnXoaDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDau.Location = new System.Drawing.Point(35, 193);
            this.btnXoaDau.Name = "btnXoaDau";
            this.btnXoaDau.Size = new System.Drawing.Size(240, 31);
            this.btnXoaDau.TabIndex = 2;
            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.UseVisualStyleBackColor = true;
            // 
            // btnXoaCuoi
            // 
            this.btnXoaCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCuoi.Location = new System.Drawing.Point(35, 230);
            this.btnXoaCuoi.Name = "btnXoaCuoi";
            this.btnXoaCuoi.Size = new System.Drawing.Size(240, 31);
            this.btnXoaCuoi.TabIndex = 2;
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.UseVisualStyleBackColor = true;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.Location = new System.Drawing.Point(30, 401);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(636, 31);
            this.btnKetThuc.TabIndex = 2;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // listNumber
            // 
            this.listNumber.FormattingEnabled = true;
            this.listNumber.Location = new System.Drawing.Point(30, 86);
            this.listNumber.Name = "listNumber";
            this.listNumber.Size = new System.Drawing.Size(300, 290);
            this.listNumber.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 434);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox grChucNang;
        private System.Windows.Forms.Button btnXoaCuoi;
        private System.Windows.Forms.Button btnXoaItem;
        private System.Windows.Forms.Button btnChanDau;
        private System.Windows.Forms.Button btnXoaDau;
        private System.Windows.Forms.Button btnLeCuoi;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.ListBox listNumber;
    }
}


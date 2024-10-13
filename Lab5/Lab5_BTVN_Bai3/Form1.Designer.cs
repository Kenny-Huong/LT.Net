namespace Lab5_BTVN_Bai3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNhan = new System.Windows.Forms.Button();
            this.hScrollGreen = new System.Windows.Forms.HScrollBar();
            this.hScrollRed = new System.Windows.Forms.HScrollBar();
            this.hScrollBlue = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdHinhTron = new System.Windows.Forms.RadioButton();
            this.rdElipse = new System.Windows.Forms.RadioButton();
            this.rdHCN = new System.Windows.Forms.RadioButton();
            this.rdHinhVuong = new System.Windows.Forms.RadioButton();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rdHinhVuong);
            this.groupBox1.Controls.Add(this.rdHCN);
            this.groupBox1.Controls.Add(this.rdElipse);
            this.groupBox1.Controls.Add(this.rdHinhTron);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnNhan
            // 
            this.btnNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhan.Location = new System.Drawing.Point(522, 286);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(101, 39);
            this.btnNhan.TabIndex = 0;
            this.btnNhan.Text = "Vẽ hình";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // hScrollGreen
            // 
            this.hScrollGreen.Location = new System.Drawing.Point(148, 334);
            this.hScrollGreen.Name = "hScrollGreen";
            this.hScrollGreen.Size = new System.Drawing.Size(239, 26);
            this.hScrollGreen.TabIndex = 1;
            this.hScrollGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollGreen_Scroll);
            // 
            // hScrollRed
            // 
            this.hScrollRed.Location = new System.Drawing.Point(148, 292);
            this.hScrollRed.Name = "hScrollRed";
            this.hScrollRed.Size = new System.Drawing.Size(239, 26);
            this.hScrollRed.TabIndex = 1;
            this.hScrollRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollRed_Scroll);
            // 
            // hScrollBlue
            // 
            this.hScrollBlue.Location = new System.Drawing.Point(148, 371);
            this.hScrollBlue.Name = "hScrollBlue";
            this.hScrollBlue.Size = new System.Drawing.Size(239, 26);
            this.hScrollBlue.TabIndex = 1;
            this.hScrollBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBlue_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Blue";
            // 
            // rdHinhTron
            // 
            this.rdHinhTron.AutoSize = true;
            this.rdHinhTron.Location = new System.Drawing.Point(20, 60);
            this.rdHinhTron.Name = "rdHinhTron";
            this.rdHinhTron.Size = new System.Drawing.Size(117, 29);
            this.rdHinhTron.TabIndex = 0;
            this.rdHinhTron.TabStop = true;
            this.rdHinhTron.Text = "Hình tròn";
            this.rdHinhTron.UseVisualStyleBackColor = true;
            // 
            // rdElipse
            // 
            this.rdElipse.AutoSize = true;
            this.rdElipse.Location = new System.Drawing.Point(20, 157);
            this.rdElipse.Name = "rdElipse";
            this.rdElipse.Size = new System.Drawing.Size(139, 29);
            this.rdElipse.TabIndex = 0;
            this.rdElipse.TabStop = true;
            this.rdElipse.Text = "Hình Elipse";
            this.rdElipse.UseVisualStyleBackColor = true;
            // 
            // rdHCN
            // 
            this.rdHCN.AutoSize = true;
            this.rdHCN.Location = new System.Drawing.Point(206, 60);
            this.rdHCN.Name = "rdHCN";
            this.rdHCN.Size = new System.Drawing.Size(163, 29);
            this.rdHCN.TabIndex = 0;
            this.rdHCN.TabStop = true;
            this.rdHCN.Text = "Hình chữ nhật";
            this.rdHCN.UseVisualStyleBackColor = true;
            // 
            // rdHinhVuong
            // 
            this.rdHinhVuong.AutoSize = true;
            this.rdHinhVuong.Location = new System.Drawing.Point(206, 157);
            this.rdHinhVuong.Name = "rdHinhVuong";
            this.rdHinhVuong.Size = new System.Drawing.Size(142, 29);
            this.rdHinhVuong.TabIndex = 0;
            this.rdHinhVuong.TabStop = true;
            this.rdHinhVuong.Text = "Hình Vuông";
            this.rdHinhVuong.UseVisualStyleBackColor = true;
            // 
            // panelPreview
            // 
            this.panelPreview.Location = new System.Drawing.Point(420, 23);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(282, 233);
            this.panelPreview.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 435);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.hScrollRed);
            this.Controls.Add(this.hScrollBlue);
            this.Controls.Add(this.hScrollGreen);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Vẽ hình";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.HScrollBar hScrollGreen;
        private System.Windows.Forms.RadioButton rdHinhVuong;
        private System.Windows.Forms.RadioButton rdHCN;
        private System.Windows.Forms.RadioButton rdElipse;
        private System.Windows.Forms.RadioButton rdHinhTron;
        private System.Windows.Forms.HScrollBar hScrollRed;
        private System.Windows.Forms.HScrollBar hScrollBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPreview;
    }
}


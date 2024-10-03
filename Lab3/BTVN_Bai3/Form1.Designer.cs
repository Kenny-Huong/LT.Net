namespace BTVN_Bai3
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
            this.txtn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnKtra = new System.Windows.Forms.Button();
            this.lqKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtn
            // 
            this.txtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn.Location = new System.Drawing.Point(150, 33);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 31);
            this.txtn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập n :";
            // 
            // btnTong
            // 
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(27, 109);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(144, 40);
            this.btnTong.TabIndex = 2;
            this.btnTong.Text = "Tính Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnKtra
            // 
            this.btnKtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKtra.Location = new System.Drawing.Point(215, 109);
            this.btnKtra.Name = "btnKtra";
            this.btnKtra.Size = new System.Drawing.Size(223, 40);
            this.btnKtra.TabIndex = 2;
            this.btnKtra.Text = "Kiểm tra số nguyên tố";
            this.btnKtra.UseVisualStyleBackColor = true;
            this.btnKtra.Click += new System.EventHandler(this.btnKtra_Click);
            // 
            // lqKQ
            // 
            this.lqKQ.AutoSize = true;
            this.lqKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lqKQ.Location = new System.Drawing.Point(33, 193);
            this.lqKQ.Name = "lqKQ";
            this.lqKQ.Size = new System.Drawing.Size(92, 25);
            this.lqKQ.TabIndex = 1;
            this.lqKQ.Text = "Kết quả ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 273);
            this.Controls.Add(this.btnKtra);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.lqKQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnKtra;
        private System.Windows.Forms.Label lqKQ;
    }
}


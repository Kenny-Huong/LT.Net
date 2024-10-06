namespace Bai1_vd
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
            this.cbbSelectColor = new System.Windows.Forms.ComboBox();
            this.btnColorChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bntClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào mừng bạn đến với Thực tập lập trình .NET";
            // 
            // cbbSelectColor
            // 
            this.cbbSelectColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbSelectColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSelectColor.FormattingEnabled = true;
            this.cbbSelectColor.Location = new System.Drawing.Point(241, 79);
            this.cbbSelectColor.Name = "cbbSelectColor";
            this.cbbSelectColor.Size = new System.Drawing.Size(286, 33);
            this.cbbSelectColor.TabIndex = 1;
            this.cbbSelectColor.SelectedIndexChanged += new System.EventHandler(this.cbbSelectColor_SelectedIndexChanged);
            // 
            // btnColorChange
            // 
            this.btnColorChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnColorChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorChange.Location = new System.Drawing.Point(241, 150);
            this.btnColorChange.Name = "btnColorChange";
            this.btnColorChange.Size = new System.Drawing.Size(111, 35);
            this.btnColorChange.TabIndex = 2;
            this.btnColorChange.Text = "Đổi màu";
            this.btnColorChange.UseVisualStyleBackColor = true;
            this.btnColorChange.Click += new System.EventHandler(this.btnColorChange_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn màu";
            // 
            // bntClose
            // 
            this.bntClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClose.Location = new System.Drawing.Point(431, 150);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(96, 35);
            this.bntClose.TabIndex = 2;
            this.bntClose.Text = "Thoát";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 243);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.btnColorChange);
            this.Controls.Add(this.cbbSelectColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSelectColor;
        private System.Windows.Forms.Button btnColorChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntClose;
    }
}


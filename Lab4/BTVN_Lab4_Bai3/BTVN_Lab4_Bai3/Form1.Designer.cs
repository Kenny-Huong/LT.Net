namespace BTVN_Lab4_Bai3
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnAllRight = new System.Windows.Forms.Button();
            this.btnAllLeft = new System.Windows.Forms.Button();
            this.btnXoaA = new System.Windows.Forms.Button();
            this.btnXoaB = new System.Windows.Forms.Button();
            this.grB = new System.Windows.Forms.GroupBox();
            this.grA = new System.Windows.Forms.GroupBox();
            this.listA = new System.Windows.Forms.ListBox();
            this.listB = new System.Windows.Forms.ListBox();
            this.grB.SuspendLayout();
            this.grA.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(190, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 31);
            this.txtName.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(488, 84);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 35);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(232, 203);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(83, 35);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(326, 203);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(83, 35);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnAllRight
            // 
            this.btnAllRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllRight.Location = new System.Drawing.Point(232, 255);
            this.btnAllRight.Name = "btnAllRight";
            this.btnAllRight.Size = new System.Drawing.Size(83, 35);
            this.btnAllRight.TabIndex = 2;
            this.btnAllRight.Text = ">>";
            this.btnAllRight.UseVisualStyleBackColor = true;
            this.btnAllRight.Click += new System.EventHandler(this.btnAllRight_Click);
            // 
            // btnAllLeft
            // 
            this.btnAllLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllLeft.Location = new System.Drawing.Point(326, 255);
            this.btnAllLeft.Name = "btnAllLeft";
            this.btnAllLeft.Size = new System.Drawing.Size(83, 35);
            this.btnAllLeft.TabIndex = 2;
            this.btnAllLeft.Text = "<<";
            this.btnAllLeft.UseVisualStyleBackColor = true;
            this.btnAllLeft.Click += new System.EventHandler(this.btnAllLeft_Click);
            // 
            // btnXoaA
            // 
            this.btnXoaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaA.Location = new System.Drawing.Point(64, 377);
            this.btnXoaA.Name = "btnXoaA";
            this.btnXoaA.Size = new System.Drawing.Size(83, 35);
            this.btnXoaA.TabIndex = 2;
            this.btnXoaA.Text = "Xóa";
            this.btnXoaA.UseVisualStyleBackColor = true;
            this.btnXoaA.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnXoaB
            // 
            this.btnXoaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaB.Location = new System.Drawing.Point(488, 377);
            this.btnXoaB.Name = "btnXoaB";
            this.btnXoaB.Size = new System.Drawing.Size(83, 35);
            this.btnXoaB.TabIndex = 2;
            this.btnXoaB.Text = "Xóa";
            this.btnXoaB.UseVisualStyleBackColor = true;
            this.btnXoaB.Click += new System.EventHandler(this.button7_Click);
            // 
            // grB
            // 
            this.grB.Controls.Add(this.listB);
            this.grB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grB.Location = new System.Drawing.Point(440, 146);
            this.grB.Name = "grB";
            this.grB.Size = new System.Drawing.Size(213, 208);
            this.grB.TabIndex = 3;
            this.grB.TabStop = false;
            this.grB.Text = "Lớp B :";
            // 
            // grA
            // 
            this.grA.Controls.Add(this.listA);
            this.grA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grA.Location = new System.Drawing.Point(12, 146);
            this.grA.Name = "grA";
            this.grA.Size = new System.Drawing.Size(205, 208);
            this.grA.TabIndex = 3;
            this.grA.TabStop = false;
            this.grA.Text = "Lớp A :";
            // 
            // listA
            // 
            this.listA.FormattingEnabled = true;
            this.listA.ItemHeight = 25;
            this.listA.Location = new System.Drawing.Point(6, 48);
            this.listA.Name = "listA";
            this.listA.Size = new System.Drawing.Size(193, 154);
            this.listA.TabIndex = 4;
            this.listA.SelectedIndexChanged += new System.EventHandler(this.listA_SelectedIndexChanged);
            // 
            // listB
            // 
            this.listB.FormattingEnabled = true;
            this.listB.ItemHeight = 25;
            this.listB.Location = new System.Drawing.Point(6, 48);
            this.listB.Name = "listB";
            this.listB.Size = new System.Drawing.Size(201, 154);
            this.listB.TabIndex = 4;
            this.listB.SelectedIndexChanged += new System.EventHandler(this.listB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 466);
            this.Controls.Add(this.grA);
            this.Controls.Add(this.grB);
            this.Controls.Add(this.btnXoaB);
            this.Controls.Add(this.btnAllLeft);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnXoaA);
            this.Controls.Add(this.btnAllRight);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grB.ResumeLayout(false);
            this.grA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnAllRight;
        private System.Windows.Forms.Button btnAllLeft;
        private System.Windows.Forms.Button btnXoaA;
        private System.Windows.Forms.Button btnXoaB;
        private System.Windows.Forms.GroupBox grB;
        private System.Windows.Forms.GroupBox grA;
        private System.Windows.Forms.ListBox listB;
        private System.Windows.Forms.ListBox listA;
    }
}


namespace DVES_DEMO
{
    partial class dangnhapADM
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
            this.txttendnADM = new System.Windows.Forms.TextBox();
            this.txtmatkhauADM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnxacnhanADM = new System.Windows.Forms.Button();
            this.btnquaylaiADM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(83, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG NHẬP TÀI KHOẢN ADMIN";
            // 
            // txttendnADM
            // 
            this.txttendnADM.Location = new System.Drawing.Point(183, 83);
            this.txttendnADM.Name = "txttendnADM";
            this.txttendnADM.Size = new System.Drawing.Size(150, 20);
            this.txttendnADM.TabIndex = 0;
            this.txttendnADM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmatkhauADM
            // 
            this.txtmatkhauADM.Location = new System.Drawing.Point(183, 132);
            this.txtmatkhauADM.Name = "txtmatkhauADM";
            this.txtmatkhauADM.PasswordChar = '*';
            this.txtmatkhauADM.Size = new System.Drawing.Size(150, 20);
            this.txtmatkhauADM.TabIndex = 1;
            this.txtmatkhauADM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "TÊN ĐĂNG NHẬP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "MẬT KHẨU";
            // 
            // btnxacnhanADM
            // 
            this.btnxacnhanADM.AutoSize = true;
            this.btnxacnhanADM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnxacnhanADM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxacnhanADM.Location = new System.Drawing.Point(89, 206);
            this.btnxacnhanADM.Name = "btnxacnhanADM";
            this.btnxacnhanADM.Size = new System.Drawing.Size(106, 31);
            this.btnxacnhanADM.TabIndex = 6;
            this.btnxacnhanADM.Text = "XÁC NHẬN";
            this.btnxacnhanADM.UseVisualStyleBackColor = true;
            this.btnxacnhanADM.Click += new System.EventHandler(this.BtnxacnhanADM_Click);
            // 
            // btnquaylaiADM
            // 
            this.btnquaylaiADM.AutoSize = true;
            this.btnquaylaiADM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnquaylaiADM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquaylaiADM.Location = new System.Drawing.Point(218, 206);
            this.btnquaylaiADM.Name = "btnquaylaiADM";
            this.btnquaylaiADM.Size = new System.Drawing.Size(95, 29);
            this.btnquaylaiADM.TabIndex = 7;
            this.btnquaylaiADM.Text = "QUAY LẠI";
            this.btnquaylaiADM.UseVisualStyleBackColor = true;
            this.btnquaylaiADM.Click += new System.EventHandler(this.BtnquaylaiADM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVES_DEMO.Properties.Resources.logocty;
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dangnhapADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 278);
            this.Controls.Add(this.btnquaylaiADM);
            this.Controls.Add(this.btnxacnhanADM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmatkhauADM);
            this.Controls.Add(this.txttendnADM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "dangnhapADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttendnADM;
        private System.Windows.Forms.TextBox txtmatkhauADM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnxacnhanADM;
        private System.Windows.Forms.Button btnquaylaiADM;
    }
}
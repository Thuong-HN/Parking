namespace DVES_DEMO
{
    partial class doitaikhoan
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
            this.btnql = new System.Windows.Forms.Button();
            this.btnxn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdoimk = new System.Windows.Forms.TextBox();
            this.txtdoitendn = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(116, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ NHÀ XE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.btnql);
            this.groupBox1.Controls.Add(this.btnxn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtdoimk);
            this.groupBox1.Controls.Add(this.txtdoitendn);
            this.groupBox1.Location = new System.Drawing.Point(13, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin cần thay đổi";
            // 
            // btnql
            // 
            this.btnql.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnql.Location = new System.Drawing.Point(253, 178);
            this.btnql.Name = "btnql";
            this.btnql.Size = new System.Drawing.Size(86, 44);
            this.btnql.TabIndex = 7;
            this.btnql.Text = "Quay Lại";
            this.btnql.UseVisualStyleBackColor = true;
            this.btnql.Click += new System.EventHandler(this.Btnql_Click);
            // 
            // btnxn
            // 
            this.btnxn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnxn.Location = new System.Drawing.Point(113, 178);
            this.btnxn.Name = "btnxn";
            this.btnxn.Size = new System.Drawing.Size(89, 44);
            this.btnxn.TabIndex = 6;
            this.btnxn.Text = "Xác Nhận";
            this.btnxn.UseVisualStyleBackColor = true;
            this.btnxn.Click += new System.EventHandler(this.Btnxn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên đăng nhập";
            // 
            // txtdoimk
            // 
            this.txtdoimk.Location = new System.Drawing.Point(190, 101);
            this.txtdoimk.Name = "txtdoimk";
            this.txtdoimk.PasswordChar = '*';
            this.txtdoimk.Size = new System.Drawing.Size(176, 26);
            this.txtdoimk.TabIndex = 1;
            this.txtdoimk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdoitendn
            // 
            this.txtdoitendn.Location = new System.Drawing.Point(190, 41);
            this.txtdoitendn.Name = "txtdoitendn";
            this.txtdoitendn.Size = new System.Drawing.Size(176, 26);
            this.txtdoitendn.TabIndex = 0;
            this.txtdoitendn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVES_DEMO.Properties.Resources.logocty;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // doitaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "doitaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Tài Khoản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdoimk;
        private System.Windows.Forms.TextBox txtdoitendn;
        private System.Windows.Forms.Button btnql;
        private System.Windows.Forms.Button btnxn;
    }
}
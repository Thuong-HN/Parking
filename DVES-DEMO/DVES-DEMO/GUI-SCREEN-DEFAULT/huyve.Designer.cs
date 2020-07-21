namespace DVES_DEMO
{
    partial class huyve
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
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtmathe = new System.Windows.Forms.TextBox();
            this.txtbienso = new System.Windows.Forms.TextBox();
            this.txtloaixe = new System.Windows.Forms.TextBox();
            this.txttien = new System.Windows.Forms.TextBox();
            this.txtngaydk = new System.Windows.Forms.TextBox();
            this.txtngayhethan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picsearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtten
            // 
            this.txtten.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtten.Location = new System.Drawing.Point(249, 92);
            this.txtten.Margin = new System.Windows.Forms.Padding(5);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(337, 29);
            this.txtten.TabIndex = 10;
            this.txtten.Text = "Nhập tên người dùng";
            this.txtten.Enter += new System.EventHandler(this.Txtten_Enter);
            this.txtten.Leave += new System.EventHandler(this.Txtten_Leave);
            // 
            // txtmathe
            // 
            this.txtmathe.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtmathe.Location = new System.Drawing.Point(37, 177);
            this.txtmathe.Margin = new System.Windows.Forms.Padding(5);
            this.txtmathe.Name = "txtmathe";
            this.txtmathe.ReadOnly = true;
            this.txtmathe.Size = new System.Drawing.Size(202, 29);
            this.txtmathe.TabIndex = 11;
            this.txtmathe.Text = "Mã thẻ";
            // 
            // txtbienso
            // 
            this.txtbienso.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtbienso.Location = new System.Drawing.Point(249, 177);
            this.txtbienso.Margin = new System.Windows.Forms.Padding(5);
            this.txtbienso.Name = "txtbienso";
            this.txtbienso.ReadOnly = true;
            this.txtbienso.Size = new System.Drawing.Size(164, 29);
            this.txtbienso.TabIndex = 12;
            this.txtbienso.Text = "Biển số";
            // 
            // txtloaixe
            // 
            this.txtloaixe.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtloaixe.Location = new System.Drawing.Point(423, 177);
            this.txtloaixe.Margin = new System.Windows.Forms.Padding(5);
            this.txtloaixe.Name = "txtloaixe";
            this.txtloaixe.ReadOnly = true;
            this.txtloaixe.Size = new System.Drawing.Size(164, 29);
            this.txtloaixe.TabIndex = 13;
            this.txtloaixe.Text = "Loại xe";
            // 
            // txttien
            // 
            this.txttien.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txttien.Location = new System.Drawing.Point(597, 177);
            this.txttien.Margin = new System.Windows.Forms.Padding(5);
            this.txttien.Name = "txttien";
            this.txttien.ReadOnly = true;
            this.txttien.Size = new System.Drawing.Size(164, 29);
            this.txttien.TabIndex = 14;
            this.txttien.Text = "Tiền";
            // 
            // txtngaydk
            // 
            this.txtngaydk.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtngaydk.Location = new System.Drawing.Point(158, 257);
            this.txtngaydk.Margin = new System.Windows.Forms.Padding(5);
            this.txtngaydk.Name = "txtngaydk";
            this.txtngaydk.ReadOnly = true;
            this.txtngaydk.Size = new System.Drawing.Size(255, 29);
            this.txtngaydk.TabIndex = 15;
            this.txtngaydk.Text = "Ngày đăng ký";
            // 
            // txtngayhethan
            // 
            this.txtngayhethan.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtngayhethan.Location = new System.Drawing.Point(423, 257);
            this.txtngayhethan.Margin = new System.Windows.Forms.Padding(5);
            this.txtngayhethan.Name = "txtngayhethan";
            this.txtngayhethan.ReadOnly = true;
            this.txtngayhethan.Size = new System.Drawing.Size(258, 29);
            this.txtngayhethan.TabIndex = 16;
            this.txtngayhethan.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 8;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(250, 322);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(116, 63);
            this.btnxacnhan.TabIndex = 0;
            this.btnxacnhan.Text = "Xác Nhận Hủy Vé";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.Btnxacnhan_Click);
            // 
            // btnquaylai
            // 
            this.btnquaylai.Location = new System.Drawing.Point(423, 322);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(119, 63);
            this.btnquaylai.TabIndex = 18;
            this.btnquaylai.Text = "Quay Lại";
            this.btnquaylai.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVES_DEMO.Properties.Resources.logocty;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // picsearch
            // 
            this.picsearch.Image = global::DVES_DEMO.Properties.Resources.Find;
            this.picsearch.Location = new System.Drawing.Point(617, 89);
            this.picsearch.Name = "picsearch";
            this.picsearch.Size = new System.Drawing.Size(32, 32);
            this.picsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picsearch.TabIndex = 20;
            this.picsearch.TabStop = false;
            this.picsearch.Click += new System.EventHandler(this.Picsearch_Click);
            // 
            // huyve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 429);
            this.Controls.Add(this.picsearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtngayhethan);
            this.Controls.Add(this.txtngaydk);
            this.Controls.Add(this.txttien);
            this.Controls.Add(this.txtloaixe);
            this.Controls.Add(this.txtbienso);
            this.Controls.Add(this.txtmathe);
            this.Controls.Add(this.txtten);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "huyve";
            this.Text = "Hủy vé tháng";
            this.Load += new System.EventHandler(this.Huyve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtmathe;
        private System.Windows.Forms.TextBox txtbienso;
        private System.Windows.Forms.TextBox txtloaixe;
        private System.Windows.Forms.TextBox txttien;
        private System.Windows.Forms.TextBox txtngaydk;
        private System.Windows.Forms.TextBox txtngayhethan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picsearch;
    }
}